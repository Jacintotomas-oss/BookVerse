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
            var repoUsuario = new UsuarioRepository();

            if (repoEmpleado.ValidarLogin(usuario, hash))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (repoUsuario.ValidarLogin(usuario, hash))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void btnSinCuenta_Click(object sender, EventArgs e)
        {
            Registrar formRegistro = new Registrar();
            formRegistro.Show();
            this.Hide();

        }
    }
}