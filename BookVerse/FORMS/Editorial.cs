using System;
using System.Linq;
using System.Windows.Forms;
using BookVerse.Data;
using EditorialModelo = BookVerse.Models.Editorial;   // el formulario también se llama Editorial
using SerieModelo = BookVerse.Models.Series;

namespace BookVerse.FORMS
{
    public partial class Editorial : Form
    {
        private int idEditorial = 0;
        private int idSerie = 0;

        private static void Conectar(Button boton, EventHandler manejador)
        {
            boton.Click -= manejador;
            boton.Click += manejador;
        }

        public Editorial()
        {
            InitializeComponent();

            // Longitudes de las columnas en la BD
            TxtEditorial.MaxLength = 100;
            txtPais.MaxLength = 100;
            TxtNombreSerie.MaxLength = 100;

            ConfigurarGrid(dgvEditoriales);
            ConfigurarGrid(dgvSeries);

            // Editoriales
            Conectar(btnAgregar, btnAgregar_Click);
            Conectar(btnActualizar, btnActualizar_Click);
            Conectar(btnBorrar, btnBorrar_Click);
            Conectar(btnLimpiar, btnLimpiar_Click);
            dgvEditoriales.CellClick += dgvEditoriales_CellClick;

            // Series
            Conectar(buttonAgregar, buttonAgregar_Click);
            Conectar(buttonActualizar, buttonActualizar_Click);
            Conectar(buttonBorrar, buttonBorrar_Click);
            Conectar(buttonLimpiar, buttonLimpiar_Click);
            dgvSeries.CellClick += dgvSeries_CellClick;

            Load += (s, e) => { CargarEditoriales(); CargarSeries(); };
        }

        private static void ConfigurarGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
        }
        //carga las editoriales

        private void CargarEditoriales()
        {
            using (var contexto = new LibreriaContext())
            {
                dgvEditoriales.DataSource = contexto.Editorials
                    .OrderBy(ed => ed.Nombre)
                    .Select(ed => new { ed.IdEditorial, ed.Nombre, ed.Pais })
                    .ToList();
            }

            dgvEditoriales.Columns["IdEditorial"].Visible = false;
            dgvEditoriales.Columns["Nombre"].HeaderText = "Editorial";
            dgvEditoriales.Columns["Pais"].HeaderText = "País";
        }

        private void dgvEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvEditoriales.Rows[e.RowIndex];

            idEditorial = (int)fila.Cells["IdEditorial"].Value;
            TxtEditorial.Text = fila.Cells["Nombre"].Value?.ToString();
            txtPais.Text = fila.Cells["Pais"].Value?.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtEditorial.Text.Trim();
            string pais = txtPais.Text.Trim();

            if (nombre == "" || pais == "")
            {
                MessageBox.Show("Completa el nombre de la editorial y el país.");
                return;
            }

            using (var contexto = new LibreriaContext())
            {
                if (contexto.Editorials.Any(x => x.Nombre == nombre))
                {
                    MessageBox.Show("Ya existe una editorial con ese nombre.");
                    return;
                }

                contexto.Editorials.Add(new EditorialModelo { Nombre = nombre, Pais = pais });
                contexto.SaveChanges();
            }

            CargarEditoriales();
            LimpiarEditorial();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idEditorial == 0)
            {
                MessageBox.Show("Selecciona una editorial de la lista.");
                return;
            }

            string nombre = TxtEditorial.Text.Trim();
            string pais = txtPais.Text.Trim();

            if (nombre == "" || pais == "")
            {
                MessageBox.Show("Completa el nombre de la editorial y el país.");
                return;
            }

            using (var contexto = new LibreriaContext())
            {
                if (contexto.Editorials.Any(x => x.Nombre == nombre && x.IdEditorial != idEditorial))
                {
                    MessageBox.Show("Ya existe otra editorial con ese nombre.");
                    return;
                }

                var editorial = contexto.Editorials.Find(idEditorial);
                if (editorial == null) return;

                editorial.Nombre = nombre;
                editorial.Pais = pais;
                contexto.SaveChanges();
            }

            CargarEditoriales();
            LimpiarEditorial();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idEditorial == 0)
            {
                MessageBox.Show("Selecciona una editorial de la lista.");
                return;
            }

            try
            {
                using (var contexto = new LibreriaContext())
                {
                    int libros = contexto.Libros.Count(x => x.IdEditorial == idEditorial);
                    if (libros > 0)
                    {
                        MessageBox.Show("No se puede borrar: hay " + libros + " libro(s) de esta editorial.");
                        return;
                    }

                    var editorial = contexto.Editorials.Find(idEditorial);
                    if (editorial == null) return;

                    contexto.Editorials.Remove(editorial);
                    contexto.SaveChanges();
                }

                CargarEditoriales();
                LimpiarEditorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarEditorial();

        private void LimpiarEditorial()
        {
            idEditorial = 0;
            TxtEditorial.Clear();
            txtPais.Clear();
            dgvEditoriales.ClearSelection();
        }


        private void CargarSeries()
        {
            using (var contexto = new LibreriaContext())
            {
                dgvSeries.DataSource = contexto.Series
                    .OrderBy(se => se.Nombre)
                    .Select(se => new
                    {
                        se.IdSeries,
                        se.Nombre,
                        Libros = contexto.Libros.Count(l => l.IdSeries == se.IdSeries)
                    })
                    .ToList();
            }

            dgvSeries.Columns["IdSeries"].Visible = false;
            dgvSeries.Columns["Nombre"].HeaderText = "Serie";
            dgvSeries.Columns["Libros"].HeaderText = "Libros";
        }

        private void dgvSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvSeries.Rows[e.RowIndex];

            idSerie = (int)fila.Cells["IdSeries"].Value;
            TxtNombreSerie.Text = fila.Cells["Nombre"].Value?.ToString();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombreSerie.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Escribe el nombre de la serie.");
                return;
            }

            using (var contexto = new LibreriaContext())
            {
                if (contexto.Series.Any(x => x.Nombre == nombre))
                {
                    MessageBox.Show("Ya existe una serie con ese nombre.");
                    return;
                }

                contexto.Series.Add(new SerieModelo { Nombre = nombre });
                contexto.SaveChanges();
            }

            CargarSeries();
            LimpiarSerie();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (idSerie == 0)
            {
                MessageBox.Show("Selecciona una serie de la lista.");
                return;
            }

            string nombre = TxtNombreSerie.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Escribe el nombre de la serie.");
                return;
            }

            using (var contexto = new LibreriaContext())
            {
                if (contexto.Series.Any(x => x.Nombre == nombre && x.IdSeries != idSerie))
                {
                    MessageBox.Show("Ya existe otra serie con ese nombre.");
                    return;
                }

                var serie = contexto.Series.Find(idSerie);
                if (serie == null) return;

                serie.Nombre = nombre;
                contexto.SaveChanges();
            }

            CargarSeries();
            LimpiarSerie();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (idSerie == 0)
            {
                MessageBox.Show("Selecciona una serie de la lista.");
                return;
            }

            try
            {
                using (var contexto = new LibreriaContext())
                {
                    var libros = contexto.Libros.Where(x => x.IdSeries == idSerie).ToList();

                    if (libros.Count > 0 &&
                        MessageBox.Show("Esta serie tiene " + libros.Count + " libro(s). Quedarán sin serie. ¿Continuar?",
                                        "Borrar serie", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    // Los libros no se borran: solo pierden su serie y su número
                    foreach (var libro in libros)
                    {
                        libro.IdSeries = null;
                        libro.NumeroSerie = null;
                    }

                    var serie = contexto.Series.Find(idSerie);
                    if (serie == null) return;

                    contexto.Series.Remove(serie);
                    contexto.SaveChanges();
                }

                CargarSeries();
                LimpiarSerie();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e) => LimpiarSerie();

        private void LimpiarSerie()
        {
            idSerie = 0;
            TxtNombreSerie.Clear();
            dgvSeries.ClearSelection();
        }

        // Lo conservo por si algún Designer lo referencia
        private void label2_Click(object sender, EventArgs e) { }
    }
}