using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Conectar(btnSolicitar, btnSolicitar_Click);
            Conectar(btnRegistrarDevolucion, btnRegistrarDevolucion_Click);
            Conectar(btnLimpiar, btnLimpiar_Click);
            Conectar(btnGenerarPdf, btnGenerarPdf_Click);

            dgvPrestamos.CellClick -= dgvPrestamos_CellClick;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;

            Load -= Prestamos_Load;
            Load += Prestamos_Load;

            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;

            // Al elegir un libro (en el combo o tocando el grid) se muestra quién lo tiene
            cboLibro.SelectedValueChanged += (s, e) =>
            {
                if (cboLibro.SelectedValue is int id) MostrarDetalle(id);
                else txtDetalle.Clear();
            };

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
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los libros: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void CargarGrid()
        {
            try
            {
                dgvPrestamos.DataSource = repo.ObtenerLibrosParaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la tabla: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cboLibro.SelectedValue = (int)dgvPrestamos.Rows[e.RowIndex].Cells["IdLibro"].Value;
        }

        private int? LibroSeleccionado()
        {
            return cboLibro.SelectedValue is int id ? id : (int?)null;
        }

        // Muestra quién tiene prestados los ejemplares del libro seleccionado
        private void MostrarDetalle(int idLibro)
        {
            try
            {
                var activos = repo.ObtenerPrestamosActivos(idLibro);
                txtDetalle.Text = activos.Count == 0
                    ? "Sin ejemplares prestados."
                    : string.Join(Environment.NewLine + Environment.NewLine, activos.Select(a =>
                        $"{a.Prestatario}{Environment.NewLine}Tel.: {a.Telefono}{Environment.NewLine}Prestado: {a.Prestado}   Vence: {a.Vence}"));
            }
            catch (Exception ex)
            {
                txtDetalle.Text = "No se pudo cargar el detalle: " + (ex.InnerException?.Message ?? ex.Message);
            }
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
            MostrarDetalle(id.Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboLibro.SelectedIndex = -1;
            txtPrestatario.Clear();
            txtTelefono.Clear();
            txtDetalle.Clear();
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

//REPORTE BESTIA MAMALOONNNN

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
                page.Size(QuestPDF.Helpers.PageSizes.Letter);
                page.Margin(36);
                page.DefaultTextStyle(x => x.FontSize(10));

                // ── Encabezado ──
                page.Header().Background("#18262F").Padding(14).Row(row =>
                {
                    row.RelativeItem().Column(c =>
                    {
                        c.Item().Text("BookVerse").FontSize(24).Bold().FontColor("#D4AF6A");
                        c.Item().Text("Reporte de inventario").FontSize(12).FontColor("#E8E2D4");
                    });

                    row.ConstantItem(130).AlignMiddle().AlignRight().Column(c =>
                    {
                        c.Item().Text("Generado el").FontSize(8).FontColor("#B4B2A9");
                        c.Item().Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).FontSize(10).FontColor("#E8E2D4");
                    });
                });

                // ── Contenido ──
                page.Content().PaddingVertical(16).Column(col =>
                {
                    col.Spacing(4);

                    // Resumen
                    col.Item().Text("Resumen").FontSize(14).Bold().FontColor("#18262F");
                    col.Item().LineHorizontal(1.5f).LineColor("#D4AF6A");
                    col.Item().PaddingTop(6).Row(row =>
                    {
                        row.Spacing(10);
                        Tarjeta(row.RelativeItem(), r.Prestados.Count.ToString(), "Ejemplares prestados");
                        Tarjeta(row.RelativeItem(), r.StockBajo.Count.ToString(), "Títulos con stock bajo");
                        Tarjeta(row.RelativeItem(), r.Disponibles.Count.ToString(), "Títulos disponibles");
                    });

                    Seccion(col, "Libros prestados",
                        new[] { "Libro", "Prestado a", "Teléfono", "Vence" }, new[] { 3f, 2.5f, 1.5f, 1.2f },
                        r.Prestados.Select(x => new[] { x.Titulo, x.Prestatario, x.Telefono, x.Vence }).ToList());

                    Seccion(col, "Stock bajo",
                        new[] { "Libro", "Disponibles", "Stock total" }, new[] { 4f, 1.5f, 1.5f },
                        r.StockBajo.Select(x => new[] { x.Titulo, x.Disponibles.ToString(), x.Stock.ToString() }).ToList());

                    Seccion(col, "Libros disponibles",
                        new[] { "Libro", "Disponibles", "Stock total" }, new[] { 4f, 1.5f, 1.5f },
                        r.Disponibles.Select(x => new[] { x.Titulo, x.Disponibles.ToString(), x.Stock.ToString() }).ToList());
                });

                // ── Pie ──
                page.Footer().PaddingTop(8).Row(row =>
                {
                    row.RelativeItem().Text("BookVerse · Sistema de gestión de biblioteca")
                        .FontSize(8).FontColor("#888780");
                    row.RelativeItem().AlignRight().Text(t =>
                    {
                        t.DefaultTextStyle(x => x.FontSize(8).FontColor("#888780"));
                        t.Span("Página ");
                        t.CurrentPageNumber();
                        t.Span(" de ");
                        t.TotalPages();
                    });
                });
            })).GeneratePdf(ruta);
        }

        private static void Tarjeta(QuestPDF.Infrastructure.IContainer c, string valor, string etiqueta)
        {
            c.Background("#F5F1E8").Border(1).BorderColor("#D4AF6A").Padding(10).Column(col =>
            {
                col.Item().Text(valor).FontSize(22).Bold().FontColor("#18262F");
                col.Item().Text(etiqueta).FontSize(9).FontColor("#5F5E5A");
            });
        }

        private static void Seccion(ColumnDescriptor col, string titulo, string[] cabeceras, float[] anchos, List<string[]> filas)
        {
            col.Item().PaddingTop(14).Text(titulo).FontSize(14).Bold().FontColor("#18262F");
            col.Item().LineHorizontal(1.5f).LineColor("#D4AF6A");

            if (filas.Count == 0)
            {
                col.Item().PaddingTop(6).Text("Sin registros.").Italic().FontColor("#888780");
                return;
            }

            col.Item().PaddingTop(6).Table(tabla =>
            {
                tabla.ColumnsDefinition(c => { foreach (var a in anchos) c.RelativeColumn(a); });

                tabla.Header(h =>
                {
                    foreach (var cab in cabeceras)
                        h.Cell().Background("#18262F").Padding(5).Text(cab).Bold().FontColor("#D4AF6A");
                });

                for (int i = 0; i < filas.Count; i++)
                    foreach (var celda in filas[i])
                        tabla.Cell().Background(i % 2 == 0 ? "#F5F1E8" : "#FFFFFF").Padding(5).Text(celda);
            });
        }
    }
}