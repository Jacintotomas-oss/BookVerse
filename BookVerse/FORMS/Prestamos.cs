using System;
using System.Windows.Forms;
using BookVerse.DATA;

namespace BookVerse.FORMS
{
    public partial class Prestamos : Form
    {
        private PrestamosRepository repo = new PrestamosRepository();

        public Prestamos()
        {
            InitializeComponent();

            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;

            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            cboLibro.DisplayMember = "Titulo";
            cboLibro.ValueMember = "IdLibro";
            cboLibro.DataSource = repo.ObtenerLibros();

            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvPrestamos.DataSource = repo.ObtenerLibrosParaGrid();
        }

        // Al hacer clic en una fila del grid, el combo se posiciona en ese libro
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cboLibro.SelectedValue = (int)dgvPrestamos.Rows[e.RowIndex].Cells["IdLibro"].Value;
        }

        private int? LibroSeleccionado()
        {
            if (cboLibro.SelectedValue == null) return null;
            return (int)cboLibro.SelectedValue;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            var id = LibroSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Selecciona un libro.");
                return;
            }

            repo.Prestar(id.Value, out string mensaje);
            MessageBox.Show(mensaje);
            CargarGrid();
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            var id = LibroSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Selecciona un libro.");
                return;
            }

            repo.Devolver(id.Value, out string mensaje);
            MessageBox.Show(mensaje);
            CargarGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboLibro.SelectedIndex = -1;
            dgvPrestamos.ClearSelection();
            CargarGrid();
        }
    }
}