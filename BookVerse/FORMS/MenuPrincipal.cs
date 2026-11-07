using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using BookVerse.Data;
using BookVerse.Models;
using BookVerse.Services;

namespace BookVerse.FORMS
{
    public partial class MenuPrincipal : Form
    {
        private bool pantallaCompleta = false;

        private ToolTip toolTipLibros = new ToolTip
        {
            AutoPopDelay = 5000,
            InitialDelay = 250, // Aparece rápido (en 0.25 seg)
            ReshowDelay = 100,
            ShowAlways = true   // Se muestra siempre aunque la ventana no tenga el foco activo
        };

        public MenuPrincipal()
        {
            InitializeComponent();

            // Tamaño de la ventana, centrado al desmaximizar y arranque maximizado
            this.Size = new Size(1360, 820);
            this.MinimumSize = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen(); // Registra el centro de pantalla antes de maximizar
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(17, 24, 39);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;

            // Asegurar ancho uniforme y texto centrado en los 3 botones superiores
            foreach (var btn in new[] { btnAgregarAutor, btnAgregarLibro, btnVentaPrestamos })
            {
                btn.Size = new Size(170, 40);
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }

            // Margen inferior mediante propiedades del contenedor (sin paneles anchos extra)
            flowLayoutCatalogo.AutoScrollMargin = new Size(0, 60);
            flowLayoutCatalogo.Padding = new Padding(35, 25, 35, 60);

            // Asegurar orden de acoplamiento: panelHeader arriba y flowLayoutCatalogo ocupando el resto
            panelHeader.SendToBack();
            flowLayoutCatalogo.BringToFront();

            CentrarBotonesHeader();

            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyCode == Keys.F11) AlternarPantallaCompleta(); };

            // Invisible hasta que la intro haya terminado por completo
            this.Opacity = 0;

            Load += (s, e) => CargarCatalogo();
            Shown += (s, e) => MostrarBienvenida();
            this.Resize += (s, e) =>
            {
                CentrarBotonesHeader();
                AjustarMargenCatalogo();
                if (flowLayoutCatalogo != null)
                {
                    flowLayoutCatalogo.PerformLayout();
                    flowLayoutCatalogo.Invalidate();
                }
            };
            flowLayoutCatalogo.Resize += (s, e) => AjustarMargenCatalogo();
            panelHeader.Resize += (s, e) => CentrarBotonesHeader();
        }

        private void AjustarMargenCatalogo()
        {
            if (flowLayoutCatalogo == null || flowLayoutCatalogo.Controls.Count == 0) return;

            // Ancho real de cada tarjeta (210) + sus márgenes laterales (12 + 12 = 24) = 234 px
            const int anchoItem = 234;
            int anchoDisponible = flowLayoutCatalogo.ClientSize.Width;

            if (anchoDisponible <= 0) return;

            // Cuántas columnas completas caben en el ancho actual:
            int columnas = Math.Max(1, anchoDisponible / anchoItem);

            // Cuánto ancho ocupan esas columnas en total:
            int anchoOcupado = columnas * anchoItem;

            // Repartir el sobrante exactamente a partes iguales a izquierda y derecha:
            int paddingLateral = Math.Max(15, (anchoDisponible - anchoOcupado) / 2);

            // Asignar el padding para centrar todo el bloque:
            flowLayoutCatalogo.Padding = new Padding(
                paddingLateral,
                flowLayoutCatalogo.Padding.Top,
                paddingLateral,
                flowLayoutCatalogo.Padding.Bottom
            );
        }

        private void CentrarBotonesHeader()
        {
            if (panelHeader == null) return;

            const int anchoBoton = 170;
            const int altoBoton = 40;
            const int separacion = 20;

            int anchoTotal = (anchoBoton * 3) + (separacion * 2);
            int startX = Math.Max(12, (panelHeader.ClientSize.Width - anchoTotal) / 2);
            int posY = (panelHeader.Height - altoBoton) / 2;

            btnAgregarAutor.Location = new Point(startX, posY);
            btnAgregarLibro.Location = new Point(startX + anchoBoton + separacion, posY);
            btnVentaPrestamos.Location = new Point(startX + (anchoBoton + separacion) * 2, posY);
        }

        private void MostrarBienvenida()
        {
            try
            {
                var intro = new PantallaBienvenida(Screen.FromControl(this).Bounds);
                intro.Shown += (s, e) =>
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Opacity = 1; // Ya está listo y renderizado detrás de la intro negra
                };
                intro.FormClosed += (s, e) => this.Activate();
                intro.Show(this);
            }
            catch
            {
                this.WindowState = FormWindowState.Maximized;
                this.Opacity = 1;   // si algo falla, el menú se muestra igual
            }
        }

        private void AlternarPantallaCompleta()
        {
            pantallaCompleta = !pantallaCompleta;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = pantallaCompleta ? FormBorderStyle.None : FormBorderStyle.Sizable;
            WindowState = pantallaCompleta ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void CargarCatalogo()
        {
            try
            {
                flowLayoutCatalogo.SuspendLayout();

                foreach (Control ctrl in flowLayoutCatalogo.Controls)
                {
                    ctrl.Dispose();
                }
                flowLayoutCatalogo.Controls.Clear();

                using var context = new LibreriaContext();
                var libros = context.Libros
                    .Include(l => l.IdAutorNavigation)
                    .OrderBy(l => l.IdLibro)
                    .ToList();

                foreach (var libro in libros)
                {
                    var tarjeta = new Panel
                    {
                        Size = new Size(210, 370),
                        Margin = new Padding(12, 12, 12, 12),
                        BackColor = Color.FromArgb(31, 41, 55)
                    };

                    var pbPortada = new PictureBox
                    {
                        Location = new Point(10, 10),
                        Size = new Size(190, 265),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BackColor = Color.FromArgb(55, 65, 81),
                        Image = Portadas.Cargar(libro.IdLibro)
                    };

                    var lblTitulo = new Label
                    {
                        Location = new Point(10, 282),
                        Size = new Size(190, 42),
                        AutoSize = false,
                        AutoEllipsis = true,
                        Text = libro.Titulo,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    toolTipLibros.SetToolTip(lblTitulo, libro.Titulo);
                    toolTipLibros.SetToolTip(pbPortada, libro.Titulo); // También si pasa el mouse sobre la portada se verá el título completo

                    // Botones inferiores
                    var btnDetalles = new Button
                    {
                        Location = new Point(10, 328),
                        Size = new Size(90, 32),
                        Text = "Detalles",
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromArgb(55, 65, 81),
                        ForeColor = Color.FromArgb(209, 213, 219),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        UseVisualStyleBackColor = false
                    };
                    btnDetalles.FlatAppearance.BorderSize = 0;

                    var btnSolicitar = new Button
                    {
                        Location = new Point(105, 328),
                        Size = new Size(95, 32),
                        Text = "Solicitar",
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromArgb(37, 99, 235),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        UseVisualStyleBackColor = false
                    };
                    btnSolicitar.FlatAppearance.BorderSize = 0;

                    btnDetalles.Click += (s, e) =>
                        MessageBox.Show(
                            $"Autor: {libro.IdAutorNavigation?.Nombre ?? "Desconocido"}\n\nDescripción:\n{libro.Descripcion}",
                            libro.Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None // Sin icono para que abra limpio y en silencio
                        );

                    btnSolicitar.Click += (s, e) => new Prestamos().ShowDialog();

                    tarjeta.Controls.Add(pbPortada);
                    tarjeta.Controls.Add(lblTitulo);
                    tarjeta.Controls.Add(btnDetalles);
                    tarjeta.Controls.Add(btnSolicitar);

                    flowLayoutCatalogo.Controls.Add(tarjeta);
                }

                AjustarMargenCatalogo();
                flowLayoutCatalogo.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                flowLayoutCatalogo.ResumeLayout(true);
                MessageBox.Show("No se pudo cargar el catálogo: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        // Agregar Libro: ShowDialog para refrescar el catálogo al cerrar
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            using (var form = new Libros())
            {
                form.ShowDialog();
                if (form.HuboCambios)
                {
                    CargarCatalogo();
                }
            }
        }

        private void btnAgregarLibro_Click_1(object sender, EventArgs e) => btnAgregarLibro_Click(sender, e);
        private void btnAgregarLibro_Click_2(object sender, EventArgs e) => btnAgregarLibro_Click(sender, e);

        // Agregar Autor
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            new Autores().ShowDialog();
            // No es necesario recargar las tarjetas de libros si solo se abrió la ventana de autores.
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

    [DesignerCategory("Code")]
    internal class PantallaBienvenida : Form
    {
        private static readonly (string Texto, string Autor)[] Frases =
        {
            ("Un lector vive mil vidas antes de morir; quien nunca lee vive solo una.", "George R. R. Martin"),
            ("Los libros son espejos: solo se ve en ellos lo que uno ya lleva dentro.", "Carlos Ruiz Zafón"),
            ("Quien lee mucho y anda mucho, ve mucho y sabe mucho.", "Miguel de Cervantes"),
            ("Yo, que me figuraba el paraíso bajo la especie de una biblioteca.", "Jorge Luis Borges")
        };

        private readonly struct Particula
        {
            public readonly float X, Y, V, R, Fase;
            public readonly int A;

            public Particula(Random r, int w, int h)
            {
                X = r.Next(w);
                Y = r.Next(h);
                V = 8 + (float)r.NextDouble() * 22;       // velocidad de ascenso
                R = 1 + (float)r.NextDouble() * 2.2f;     // radio
                Fase = (float)(r.NextDouble() * 6.28);
                A = 60 + r.Next(120);                      // brillo máximo
            }
        }

        private const float DuracionTotal = 2.5f;   // 2.5 seg de frase (en vez de 7.6 seg)
        private const float DuracionSalida = 0.4f;  // Fundido rápido (en vez de 1.2 seg)
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 15 };
        private readonly Stopwatch reloj = Stopwatch.StartNew();
        private readonly List<Particula> particulas = new List<Particula>();
        private readonly string frase, autor;
        private readonly Font fuenteTitulo = new Font("Georgia", 46f, FontStyle.Bold);
        private readonly Font fuenteFrase = new Font("Georgia", 21f, FontStyle.Italic);
        private readonly Font fuenteAutor = new Font("Georgia", 14f, FontStyle.Regular);
        private readonly StringFormat centrado = new StringFormat { Alignment = StringAlignment.Center };

        private Bitmap fondo;
        private bool saliendo;
        private double inicioSalida;

        public PantallaBienvenida(Rectangle area)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Bounds = area;
            ShowInTaskbar = false;
            TopMost = true;
            BackColor = Color.Black;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            var azar = new Random();
            var elegida = Frases[azar.Next(Frases.Length)];
            frase = "“" + elegida.Texto + "”";
            autor = elegida.Autor;

            for (int i = 0; i < 45; i++)
                particulas.Add(new Particula(azar, area.Width, area.Height));

            timer.Tick += (s, e) => Cuadro();
            timer.Start();

            // Un clic o cualquier tecla salta la intro
            Click += (s, e) => Salir();
            KeyDown += (s, e) => Salir();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConstruirFondo();
        }

        // Fondo con degradado, resplandor dorado y viñeta: se dibuja una sola vez
        private void ConstruirFondo()
        {
            fondo?.Dispose();
            int w = ClientSize.Width, h = ClientSize.Height;
            fondo = new Bitmap(w, h);

            using (var g = Graphics.FromImage(fondo))
            {
                var r = new Rectangle(0, 0, w, h);
                using (var degradado = new LinearGradientBrush(r, Color.FromArgb(24, 38, 49), Color.FromArgb(10, 16, 21), LinearGradientMode.Vertical))
                    g.FillRectangle(degradado, r);

                // Resplandor dorado detrás del título
                using (var camino = new GraphicsPath())
                {
                    camino.AddEllipse(w * 0.15f, h * 0.16f, w * 0.70f, h * 0.60f);
                    using (var pg = new PathGradientBrush(camino))
                    {
                        pg.CenterColor = Color.FromArgb(55, 212, 175, 106);
                        pg.SurroundColors = new[] { Color.FromArgb(0, 212, 175, 106) };
                        g.FillPath(pg, camino);
                    }
                }

                // Viñeta: bordes oscuros
                using (var camino = new GraphicsPath())
                {
                    camino.AddEllipse(-0.25f * w, -0.25f * h, 1.5f * w, 1.5f * h);
                    using (var pg = new PathGradientBrush(camino))
                    {
                        pg.CenterColor = Color.FromArgb(0, 0, 0, 0);
                        pg.SurroundColors = new[] { Color.FromArgb(210, 0, 0, 0) };
                        g.FillPath(pg, camino);
                    }
                }
            }
        }

        private void Salir()
        {
            if (saliendo) return;
            saliendo = true;
            inicioSalida = reloj.Elapsed.TotalSeconds;
        }

        private void Cuadro()
        {
            double t = reloj.Elapsed.TotalSeconds;
            if (!saliendo && t >= DuracionTotal) Salir();

            if (saliendo)
            {
                float p = Math.Clamp((float)(t - inicioSalida) / DuracionSalida, 0f, 1f);
                Opacity = 1 - p * p * (3 - 2 * p);   // fundido suave
                if (p >= 1f)
                {
                    timer.Stop();
                    Close();
                    return;
                }
            }
            Invalidate();
        }

        private static float Progreso(float t, float inicio, float fin) =>
            Math.Clamp((t - inicio) / (fin - inicio), 0f, 1f);

        private static float Suave(float p) =>
            1 - (float)Math.Pow(1 - Math.Clamp(p, 0f, 1f), 3);

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            if (fondo != null) g.DrawImageUnscaled(fondo, 0, 0);

            float t = (float)reloj.Elapsed.TotalSeconds;
            float W = ClientSize.Width, H = ClientSize.Height;
            float cx = W / 2, cy = H * 0.44f;

            // Polvo de luz flotando
            using (var pincel = new SolidBrush(Color.Empty))
            {
                foreach (var p in particulas)
                {
                    float y = ((p.Y - p.V * t) % H + H) % H;
                    float x = p.X + (float)Math.Sin(t * 0.6f + p.Fase) * 14f;
                    float brillo = 0.55f + 0.45f * (float)Math.Sin(t * 1.3f + p.Fase);
                    int a = (int)(p.A * brillo * Suave(t / 2f));
                    pincel.Color = Color.FromArgb(Math.Clamp(a, 0, 255), 232, 200, 130);
                    g.FillEllipse(pincel, x, y, p.R * 2, p.R * 2);
                }
            }

            // Título: aparece y sube suavemente
            float aTitulo = Suave(Progreso(t, 0.1f, 0.7f));
            float subida = (1 - aTitulo) * 24f;
            using (var pincel = new SolidBrush(Color.FromArgb((int)(255 * aTitulo), 212, 175, 106)))
                g.DrawString("Bienvenido a BookVerse", fuenteTitulo, pincel,
                             new RectangleF(0, cy - 60 + subida, W, 90), centrado);

            // Línea dorada que se abre desde el centro
            float pl = Suave(Progreso(t, 0.3f, 0.9f));
            float mitad = 170f * pl;
            using (var lapiz = new Pen(Color.FromArgb((int)(200 * pl), 212, 175, 106), 1.5f))
                g.DrawLine(lapiz, cx - mitad, cy + 34, cx + mitad, cy + 34);

            // Frase
            float aFrase = Suave(Progreso(t, 0.5f, 1.2f));
            float anchoFrase = W * 0.62f;
            var medida = g.MeasureString(frase, fuenteFrase, (int)anchoFrase);
            using (var pincel = new SolidBrush(Color.FromArgb((int)(235 * aFrase), 232, 226, 212)))
                g.DrawString(frase, fuenteFrase, pincel,
                             new RectangleF(cx - anchoFrase / 2, cy + 58, anchoFrase, medida.Height + 4), centrado);

            // Autor
            float aAutor = Suave(Progreso(t, 0.8f, 1.5f));
            using (var pincel = new SolidBrush(Color.FromArgb((int)(255 * aAutor), 212, 175, 106)))
                g.DrawString("— " + autor, fuenteAutor, pincel,
                             new RectangleF(0, cy + 58 + medida.Height + 16, W, 30), centrado);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            fondo?.Dispose();
            fuenteTitulo.Dispose();
            fuenteFrase.Dispose();
            fuenteAutor.Dispose();
            centrado.Dispose();
            base.OnFormClosed(e);
        }
    }
}