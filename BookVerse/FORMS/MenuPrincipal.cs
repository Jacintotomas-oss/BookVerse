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
            Load += (s, e) => CargarCatalogo();
        }

        private void CargarCatalogo()
        {
            foreach (var t in tarjetas) { Controls.Remove(t); t.Dispose(); }
            tarjetas.Clear();

            List<Libro> libros;
            using (var contexto = new LibreriaContext())
                libros = contexto.Libros.OrderBy(l => l.IdLibro).ToList();

            const int columnas = 3, pasoX = 245, pasoY = 320, inicioX = 12, inicioY = 110;

            for (int i = 0; i < libros.Count; i++)
            {
                var libro = libros[i];

                var tarjeta = new Panel
                {
                    Size = new Size(220, 305),
                    Location = new Point(inicioX + (i % columnas) * pasoX, inicioY + (i / columnas) * pasoY)
                };

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
        }

        // Autores
        private void button1_Click(object sender, EventArgs e)
        {
            new Autores().Show();
        }

        // Libros: ShowDialog para refrescar el catálogo al cerrar
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            new Libros().ShowDialog();
            CargarCatalogo();
        }

        // Métodos que todavía puede referenciar el Designer; bórralos solo si compila sin ellos
        private void label1_Click(object sender, EventArgs e) { }
        private void Menu_Load(object sender, EventArgs e) { }
        private void buttonLeer_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void buttonDescripcion2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
    }
}