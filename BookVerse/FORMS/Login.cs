using System;
using System.Windows.Forms;
using BookVerse.Data;
using BookVerse.Services;

namespace BookVerse.FORMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Resize += Login_Resize;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Completa usuario y contraseña.");
                return;
            }

            string hash = Seguridad.HashPassword(contrasena);
            var repoEmpleado = new EmpleadoRepository();

            if (repoEmpleado.ValidarLogin(usuario, hash))
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                (this.ClientSize.Width - panel1.Width) / 2,
                (this.ClientSize.Height - panel1.Height) / 2
            );
        }
    }
}