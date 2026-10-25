using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookVerse.Data;
using BookVerse.Models;
using BookVerse.Services;

namespace BookVerse.FORMS
{
    public partial class MenuPrincipal : Form
    {
        private readonly List<Control> tarjetas = new List<Control>();

        public MenuPrincipal()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            AutoScroll = true;
            MinimumSize = new Size(680, 400);

            Load += (s, e) => CargarCatalogo();
            Resize += (s, e) => Reacomodar();
        }

        private void CargarCatalogo()
        {
            try
            {
                foreach (var t in tarjetas) { Controls.Remove(t); t.Dispose(); }
                tarjetas.Clear();

                List<Libro> libros;
                using (var contexto = new LibreriaContext())
                    libros = contexto.Libros.OrderBy(l => l.IdLibro).ToList();

                foreach (var libro in libros)
                {
                    var tarjeta = new Panel { Size = new Size(220, 305) };

                    var portada = new Panel
                    {
                        Location = new Point(8, 0),
                        Size = new Size(204, 215),
                        BackColor = SystemColors.ActiveCaption,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        BackgroundImage = Portadas.Cargar(libro.IdLibro)
                    };

                    var lblTitulo = new Label
                    {
                        Text = libro.Titulo,
                        Location = new Point(8, 220),
                        Size = new Size(204, 36),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    var btnDescripcion = new Button { Text = "Descripción", Location = new Point(8, 265), Size = new Size(96, 27) };
                    var btnSolicitar = new Button { Text = "Solicitar", Location = new Point(116, 265), Size = new Size(96, 27) };

                    string titulo = libro.Titulo;
                    string descripcion = libro.Descripcion;

                    btnDescripcion.Click += (s, e) =>
                        MessageBox.Show(string.IsNullOrWhiteSpace(descripcion) ? "Sin descripción." : descripcion, titulo);

                    btnSolicitar.Click += (s, e) => new Prestamos().Show();

                    tarjeta.Controls.AddRange(new Control[] { portada, lblTitulo, btnDescripcion, btnSolicitar });
                    Controls.Add(tarjeta);
                    tarjetas.Add(tarjeta);
                }

                Reacomodar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el catálogo: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        // Recalcula posiciones según el ancho actual de la ventana
        private void Reacomodar()
        {
            SuspendLayout();
            AutoScrollPosition = new Point(0, 0);

            const int anchoTarjeta = 220, altoTarjeta = 305, separacion = 25, margen = 12, inicioY = 110;

            // Título centrado
            label1.Left = (ClientSize.Width - label1.Width) / 2;

            // Botones de arriba: mismo ancho, apilados a la derecha
            var botones = new[] { btnAgregarLibro, btnAgregarAutor, btnVentaPrestamos };
            int anchoBoton = botones.Max(b => b.Width);
            int y = 15;
            foreach (var b in botones)
            {
                b.Width = anchoBoton;
                b.Left = ClientSize.Width - anchoBoton - 20;
                b.Top = y;
                y += b.Height + 6;
            }

            // Tarjetas: columnas según el ancho de la ventana
            int paso = anchoTarjeta + separacion;
            int columnas = Math.Max(1, (ClientSize.Width - margen) / paso);
            int anchoBloque = columnas * paso - separacion;
            int inicioX = Math.Max(margen, (ClientSize.Width - anchoBloque) / 2);

            for (int i = 0; i < tarjetas.Count; i++)
            {
                tarjetas[i].Location = new Point(
                    inicioX + (i % columnas) * paso,
                    inicioY + (i / columnas) * (altoTarjeta + separacion));
            }

            ResumeLayout();
        }

        // Agregar Libro: ShowDialog para refrescar el catálogo al cerrar
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            new Libros().ShowDialog();
            CargarCatalogo();
        }

        private void btnAgregarLibro_Click_1(object sender, EventArgs e) => btnAgregarLibro_Click(sender, e);
        private void btnAgregarLibro_Click_2(object sender, EventArgs e) => btnAgregarLibro_Click(sender, e);

        // Agregar Autor
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            new Autores().ShowDialog();
        }

        private void btnAgregarAutor_Click_1(object sender, EventArgs e) => btnAgregarAutor_Click(sender, e);
        private void button1_Click(object sender, EventArgs e) => btnAgregarAutor_Click(sender, e);

        // Ver registros de préstamos
        private void btnVentaPrestamos_Click(object sender, EventArgs e)
        {
            new Prestamos().ShowDialog();
        }

        // Los referencia el Designer: no los borres mientras aparezcan ahí
        private void label1_Click(object sender, EventArgs e) { }
        private void Menu_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void buttonLeer_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void buttonDescripcion2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
    }
}