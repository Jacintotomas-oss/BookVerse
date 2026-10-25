using BookVerse.Data;
using BookVerse.DATA;
using BookVerse.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookVerse.FORMS
{
    public partial class Autores : Form
    {
        private AutorRepository repo = new AutorRepository();
        private int idSeleccionado = 0;

        private static void Conectar(Button boton, EventHandler manejador)
        {
            boton.Click -= manejador;
            boton.Click += manejador;
        }

        public Autores()
        {
            InitializeComponent();

            Conectar(btnAgregar, btnAgregar_Click);
            Conectar(btnActualizar, btnActualizar_Click);
            Conectar(btnEliminar, btnEliminar_Click);
            Conectar(btnLimpiar, btnLimpiar_Click);

            dgvAutores.CellClick -= dgvAutores_CellClick;
            dgvAutores.CellClick += dgvAutores_CellClick;

            Load -= Autores_Load;
            Load += Autores_Load;

            this.Resize += Autores_Resize;
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            try
            {
                dgvAutores.DataSource = repo.ObtenerTodos();

                // Oculta la colección de libros que EF agrega al modelo
                if (dgvAutores.Columns["Libros"] != null)
                    dgvAutores.Columns["Libros"].Visible = false;
            }
            catch (Exception)
            {
                // [BLOQUE RESPONSIVIDAD] Evita que caiga la app si no hay DB local al diseñar
            }
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var autor = (Autore)dgvAutores.Rows[e.RowIndex].DataBoundItem;
            idSeleccionado = autor.IdAutor;
            txtNombre.Text = autor.Nombre;
            txtPais.Text = autor.Pais;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Completa nombre y país.");
                return;
            }

            repo.Agregar(new Autore { Nombre = txtNombre.Text.Trim(), Pais = txtPais.Text.Trim() });
            CargarGrid();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un autor de la lista.");
                return;
            }

            repo.Actualizar(new Autore
            {
                IdAutor = idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Pais = txtPais.Text.Trim()
            });
            CargarGrid();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un autor de la lista.");
                return;
            }

            try
            {
                repo.Eliminar(new Autore { IdAutor = idSeleccionado });
                CargarGrid();
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar: este autor tiene libros registrados.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtPais.Clear();
        }

        // [BLOQUE RESPONSIVIDAD] Centra el panel contenedor dinámicamente al cambiar el tamaño de ventana
        private void Autores_Resize(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        // Los siguientes los referencia el Designer: no los borres
        private void Nombre_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Autores_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Nombre_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }
    }
}