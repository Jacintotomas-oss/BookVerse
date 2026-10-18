using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookVerse.Data;
using BookVerse.DATA;
using BookVerse.Models;
using BookVerse.Services;

namespace BookVerse.FORMS
{
    public partial class Libros : Form
    {
        private LibroRepository repo = new LibroRepository();
        private int idSeleccionado = 0;
        private string rutaPortadaNueva = null;

        public Libros()
        {
            InitializeComponent();

            btnAgregar.Click += btnAgregar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSeleccionarPortada.Click += btnSeleccionarPortada_Click;
            dgvLibros.CellClick += dgvLibros_CellClick;
        }

        // Los referencia el Designer: no los borres
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void Libros_Load(object sender, EventArgs e)
        {
            cboAutor.DisplayMember = "Nombre";
            cboAutor.ValueMember = "IdAutor";
            cboAutor.DataSource = new AutorRepository().ObtenerTodos();

            using (var contexto = new LibreriaContext())
            {
                cboEditorial.DisplayMember = "Nombre";
                cboEditorial.ValueMember = "IdEditorial";
                cboEditorial.DataSource = contexto.Editorials.OrderBy(x => x.Nombre).ToList();

                cboCategoria.DisplayMember = "NombreCategoria";
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DataSource = contexto.Categorias.OrderBy(x => x.NombreCategoria).ToList();

                var series = contexto.Series.OrderBy(x => x.Nombre).ToList();
                series.Insert(0, new Series { IdSeries = 0, Nombre = "(Sin serie)" });
                cboSerie.DisplayMember = "Nombre";
                cboSerie.ValueMember = "IdSeries";
                cboSerie.DataSource = series;
            }

            CargarGrid();
        }

        private void CargarGrid() => dgvLibros.DataSource = repo.ObtenerParaGrid();

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.");
                return false;
            }
            if (cboAutor.SelectedValue == null || cboEditorial.SelectedValue == null || cboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Registra primero al menos un autor, una editorial y una categoría.");
                return false;
            }
            return true;
        }

        private int? LeerIdSerie()
        {
            int id = (int)cboSerie.SelectedValue;
            return id == 0 ? (int?)null : id;
        }

        private int? LeerNumeroSerie() =>
            int.TryParse(txtNumeroSerie.Text, out var n) ? n : (int?)null;

        private void btnSeleccionarPortada_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                rutaPortadaNueva = dlg.FileName;
                using (var img = Image.FromFile(rutaPortadaNueva))
                    pnlPortada.BackgroundImage = new Bitmap(img);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var libro = new Libro
            {
                Titulo = txtTitulo.Text.Trim(),
                IdAutor = (int)cboAutor.SelectedValue,
                IdEditorial = (int)cboEditorial.SelectedValue,
                IdCategoria = (int)cboCategoria.SelectedValue,
                IdSeries = LeerIdSerie(),
                NumeroSerie = LeerNumeroSerie(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            using (var contexto = new LibreriaContext())
            {
                contexto.Libros.Add(libro);
                contexto.SaveChanges();   // aquí EF llena libro.IdLibro
            }

            if (rutaPortadaNueva != null)
                Portadas.Guardar(libro.IdLibro, rutaPortadaNueva);

            CargarGrid();
            Limpiar();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idSeleccionado = (int)dgvLibros.Rows[e.RowIndex].Cells["IdLibro"].Value;

            var libro = repo.ObtenerPorId(idSeleccionado);
            txtTitulo.Text = libro.Titulo;
            cboAutor.SelectedValue = libro.IdAutor;
            cboEditorial.SelectedValue = libro.IdEditorial;
            cboCategoria.SelectedValue = libro.IdCategoria;
            cboSerie.SelectedValue = libro.IdSeries ?? 0;
            txtNumeroSerie.Text = libro.NumeroSerie?.ToString();
            txtDescripcion.Text = libro.Descripcion;

            rutaPortadaNueva = null;
            pnlPortada.BackgroundImage = Portadas.Cargar(idSeleccionado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un libro de la lista.");
                return;
            }
            if (!Validar()) return;

            using (var contexto = new LibreriaContext())
            {
                var libro = contexto.Libros.Find(idSeleccionado);
                if (libro == null) return;

                libro.Titulo = txtTitulo.Text.Trim();
                libro.IdAutor = (int)cboAutor.SelectedValue;
                libro.IdEditorial = (int)cboEditorial.SelectedValue;
                libro.IdCategoria = (int)cboCategoria.SelectedValue;
                libro.IdSeries = LeerIdSerie();
                libro.NumeroSerie = LeerNumeroSerie();
                libro.Descripcion = txtDescripcion.Text.Trim();
                contexto.SaveChanges();
            }

            if (rutaPortadaNueva != null)
                Portadas.Guardar(idSeleccionado, rutaPortadaNueva);

            CargarGrid();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un libro de la lista.");
                return;
            }

            try
            {
                using (var contexto = new LibreriaContext())
                {
                    var libro = contexto.Libros.Find(idSeleccionado);
                    if (libro == null) return;
                    contexto.Libros.Remove(libro);
                    contexto.SaveChanges();
                }
                Portadas.Borrar(idSeleccionado);
                CargarGrid();
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar: este libro tiene préstamos registrados.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            idSeleccionado = 0;
            rutaPortadaNueva = null;
            txtTitulo.Clear();
            txtNumeroSerie.Clear();
            txtDescripcion.Clear();
            cboSerie.SelectedValue = 0;
            pnlPortada.BackgroundImage = null;
        }

        private void True(object sender, ScrollEventArgs e)
        {

        }
    }
}