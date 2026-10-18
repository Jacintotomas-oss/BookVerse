using BookVerse.Data;
using BookVerse.DATA;
using BookVerse.Models;
using System;
using System.Windows.Forms;

namespace BookVerse.FORMS
{
    public partial class Autores : Form
    {
        private AutorRepository repo = new AutorRepository();
        private int idSeleccionado = 0;

        public Autores()
        {
            InitializeComponent();

            // Conectados desde código para no tocar el Designer
            dgvAutores.CellClick += dgvAutores_CellClick;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            Load += Autores_Load;
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvAutores.DataSource = repo.ObtenerTodos();

            // Oculta la colección de libros que EF agrega al modelo
            if (dgvAutores.Columns["Libros"] != null)
                dgvAutores.Columns["Libros"].Visible = false;
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

        // Los siguientes los referencia el Designer: no los borres
        private void Nombre_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}