using System;
using System.Drawing;
using System.IO;
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
            Conectar(btnGenerarPdf, btnGenerarPdf_Click); // Conectado limpio aquí

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
                // Evita que caiga la app si no hay BD local al diseñar
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

        private void btnSolicitar_Click_1(object sender, EventArgs e) => btnSolicitar_Click(sender, e);

        private void btnGenerarPdf_Click(object sender, EventArgs e)

        {
            try
            {
                ReporteInventario reporte = repo.GenerarReporte();
                string rutaPdf = repo.RutaReporte();

                using (StreamWriter sw = new StreamWriter(rutaPdf))
                {
                    sw.WriteLine("========================================");
                    sw.WriteLine("       BOOKVERSE - REPORTE DE INVENTARIO   ");
                    sw.WriteLine("========================================");
                    sw.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n");

                    foreach (var seccion in reporte.Secciones())
                    {
                        sw.WriteLine($"--- {seccion.Titulo.ToUpper()} ---");
                        if (seccion.Lineas.Count == 0)
                        {
                            sw.WriteLine("  (Sin registros)");
                        }
                        else
                        {
                            foreach (var linea in seccion.Lineas)
                            {
                                sw.WriteLine($"  * {linea}");
                            }
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show($"Reporte generado en:\n{rutaPdf}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}