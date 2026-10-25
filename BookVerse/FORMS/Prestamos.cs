using System;
using System.Drawing;
using System.Windows.Forms;
using BookVerse.DATA;

namespace BookVerse.FORMS
{
    public partial class Prestamos : Form
    {
        private PrestamosRepository repo = new PrestamosRepository();

        private static void Conectar(Button boton, EventHandler manejador)
        {
            boton.Click -= manejador;
            boton.Click += manejador;
        }

        public Prestamos()
        {
            InitializeComponent();

            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Conectar(btnSolicitar, btnSolicitar_Click);
            Conectar(btnRegistrarDevolucion, btnRegistrarDevolucion_Click);
            Conectar(btnLimpiar, btnLimpiar_Click);

            dgvPrestamos.CellClick -= dgvPrestamos_CellClick;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;

            Load -= Prestamos_Load;
            Load += Prestamos_Load;

            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Resize += Prestamos_Resize;
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            try
            {
                cboLibro.DisplayMember = "Titulo";
                cboLibro.ValueMember = "IdLibro";
                cboLibro.DataSource = repo.ObtenerLibros();

                CargarGrid();
            }
            catch (Exception)
            {
                // [BLOQUE RESPONSIVIDAD] Evita que caiga la app si no hay BD local al diseñar
            }
        }

        private void CargarGrid()
        {
            try
            {
                dgvPrestamos.DataSource = repo.ObtenerLibrosParaGrid();
            }
            catch (Exception)
            {
                // Evita excepciones si no hay conexión al refrescar la tabla
            }
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

        // [BLOQUE RESPONSIVIDAD] Centra el panel contenedor dinámicamente al cambiar el tamaño de ventana
        private void Prestamos_Resize(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSolicitar_Click_1(object sender, EventArgs e)
        {

        }
    }
}