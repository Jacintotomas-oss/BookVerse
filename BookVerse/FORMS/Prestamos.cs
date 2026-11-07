using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BookVerse.DATA;
using QuestPDF.Fluent;

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

            this.BackgroundImage = null;
            this.ClientSize = new Size(950, 580);
            this.Size = new Size(966, 619);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(17, 24, 39);

            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.EnableHeadersVisualStyles = false;

            Conectar(btnSolicitar, btnSolicitar_Click);
            Conectar(btnRegistrarDevolucion, btnRegistrarDevolucion_Click);
            Conectar(btnLimpiar, btnLimpiar_Click);
            Conectar(btnGenerarPdf, btnGenerarPdf_Click);

            dgvPrestamos.CellClick -= dgvPrestamos_CellClick;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;

            Load -= Prestamos_Load;
            Load += Prestamos_Load;

            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Resize += Prestamos_Resize;

            cboLibro.SelectedValueChanged += (s, e) =>
            {
                if (cboLibro.SelectedValue is int id) MostrarDetalle(id);
                else txtDetalle.Clear();
            };
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

            string nombre = txtPrestatario.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            if (nombre == "" || telefono.Count(char.IsDigit) < 8)
            {
                MessageBox.Show("Escribe el nombre y un teléfono válido (8 dígitos) de quien se lleva el libro.");
                return;
            }

            if (repo.Prestar(id.Value, nombre, telefono, out string mensaje))
            {
                txtPrestatario.Clear();
                txtTelefono.Clear();
            }
            MessageBox.Show(mensaje);
            CargarGrid();
            MostrarDetalle(id.Value);
        }

        private void MostrarDetalle(int idLibro)
        {
            var activos = repo.ObtenerPrestamosActivos(idLibro);
            txtDetalle.Text = activos.Count == 0
                ? "Sin ejemplares prestados."
                : string.Join(Environment.NewLine + Environment.NewLine, activos.Select(a =>
                    $"{a.Prestatario}{Environment.NewLine}Tel.: {a.Telefono}{Environment.NewLine}Prestado: {a.Prestado}   Vence: {a.Vence}"));
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
            if (panel1 != null && panel1.Dock == DockStyle.None)
            {
                panel1.Location = new Point(
                    Math.Max(0, (this.ClientSize.Width - panel1.Width) / 2),
                    Math.Max(0, (this.ClientSize.Height - panel1.Height) / 2)
                );
            }
        }

        private void btnSolicitar_Click_1(object sender, EventArgs e) => btnSolicitar_Click(sender, e);

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = repo.RutaReporte();   // Documentos\BookVerse\Reportes\Reporte_Inventario.pdf
                ExportarPdf(repo.GenerarReporte(), ruta);

                MessageBox.Show($"Reporte generado en:\n{ruta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("explorer.exe", $"/select,\"{ruta}\"");   // abre la carpeta con el archivo marcado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarPdf(ReporteInventario r, string ruta)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            Document.Create(doc => doc.Page(page =>
            {
                page.Margin(40);
                page.DefaultTextStyle(x => x.FontSize(11));
                page.Header().Text("BookVerse · Reporte de inventario").FontSize(20).Bold();

                page.Content().PaddingVertical(15).Column(col =>
                {
                    col.Spacing(6);
                    foreach (var (titulo, lineas) in r.Secciones())
                    {
                        col.Item().PaddingTop(10).Text(titulo).FontSize(14).Bold();
                        if (lineas.Count == 0) col.Item().Text("Sin datos.").Italic();
                        foreach (var l in lineas) col.Item().Text("• " + l);
                    }
                });

                page.Footer().AlignCenter().Text(t =>
                {
                    t.Span($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm} · Página ");
                    t.CurrentPageNumber();
                });
            })).GeneratePdf(ruta);
        }
    }
}
