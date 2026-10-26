using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
        private bool pantallaCompleta = false;

        public MenuPrincipal()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            AutoScroll = true;
            MinimumSize = new Size(680, 400);

            // Siempre inicia en pantalla completa (maximizado); F11 alterna sin bordes
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyCode == Keys.F11) AlternarPantallaCompleta(); };

            // Invisible hasta que la intro esté encima, para que no se vea ni un parpadeo
            Opacity = 0;

            Load += (s, e) => CargarCatalogo();
            Shown += (s, e) => MostrarBienvenida();
            Resize += (s, e) => Reacomodar();
        }

        private void MostrarBienvenida()
        {
            try
            {
                var intro = new PantallaBienvenida(Screen.FromControl(this).Bounds);
                intro.FormClosed += (s, e) => Activate();
                intro.Show(this);
                Opacity = 1;   // el menú ya está listo debajo de la intro
            }
            catch
            {
                Opacity = 1;   // si algo falla, el menú se muestra igual
            }
        }

        private void AlternarPantallaCompleta()
        {
            pantallaCompleta = !pantallaCompleta;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = pantallaCompleta ? FormBorderStyle.None : FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
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
            //label1.Left = (ClientSize.Width - label1.Width) / 2;

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

        private const float DuracionTotal = 7.6f;   // segundos antes del fundido final
        private const float DuracionSalida = 1.2f;  // duración del fundido de salida
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
            if (saliendo || reloj.Elapsed.TotalSeconds < 0.5) return;   // ignora clics accidentales
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
            float aTitulo = Suave(Progreso(t, 0.8f, 2.2f));
            float subida = (1 - aTitulo) * 24f;
            using (var pincel = new SolidBrush(Color.FromArgb((int)(255 * aTitulo), 212, 175, 106)))
                g.DrawString("Bienvenido a BookVerse", fuenteTitulo, pincel,
                             new RectangleF(0, cy - 60 + subida, W, 90), centrado);

            // Línea dorada que se abre desde el centro
            float pl = Suave(Progreso(t, 1.6f, 2.8f));
            float mitad = 170f * pl;
            using (var lapiz = new Pen(Color.FromArgb((int)(200 * pl), 212, 175, 106), 1.5f))
                g.DrawLine(lapiz, cx - mitad, cy + 34, cx + mitad, cy + 34);

            // Frase
            float aFrase = Suave(Progreso(t, 2.6f, 4.0f));
            float anchoFrase = W * 0.62f;
            var medida = g.MeasureString(frase, fuenteFrase, (int)anchoFrase);
            using (var pincel = new SolidBrush(Color.FromArgb((int)(235 * aFrase), 232, 226, 212)))
                g.DrawString(frase, fuenteFrase, pincel,
                             new RectangleF(cx - anchoFrase / 2, cy + 58, anchoFrase, medida.Height + 4), centrado);

            // Autor
            float aAutor = Suave(Progreso(t, 3.4f, 4.6f));
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