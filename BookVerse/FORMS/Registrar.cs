using System;
using System.Linq;
using System.Windows.Forms;
using BookVerse.Data;
using BookVerse.Services;

namespace BookVerse.FORMS
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            checkEmpleado.CheckedChanged += checkEmpleado_CheckedChanged;
            txtDui.TextChanged += txtDui_TextChanged;
            txtDui.Visible = checkEmpleado.Checked;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void Registrar_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void checkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtDui.Visible = checkEmpleado.Checked;
        }

        // Auto-formatea el DUI como ########-# mientras se escribe
        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            txtDui.TextChanged -= txtDui_TextChanged; // evita bucle infinito

            string soloDigitos = new string(txtDui.Text.Where(char.IsDigit).ToArray());

            if (soloDigitos.Length > 9)
                soloDigitos = soloDigitos.Substring(0, 9);

            string formateado = soloDigitos;
            if (soloDigitos.Length > 8)
                formateado = soloDigitos.Substring(0, 8) + "-" + soloDigitos.Substring(8);

            txtDui.Text = formateado;
            txtDui.SelectionStart = txtDui.Text.Length; // cursor al final

            txtDui.TextChanged += txtDui_TextChanged;
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();      // Nombre
            string usuario = textBox2.Text.Trim();     // Usuario
            string contrasena = textBox3.Text;          // Contraseña
            string confirmar = textBox4.Text;            // Confirmar Contraseña
            string email = textBox5.Text.Trim();        // Email

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string hash = Seguridad.HashPassword(contrasena);

            if (checkEmpleado.Checked)
            {
                string dui = txtDui.Text.Trim();

                if (string.IsNullOrEmpty(dui) || dui.Length != 10)
                {
                    MessageBox.Show("Ingresa un DUI válido (########-#).");
                    return;
                }

                var repoEmpleado = new EmpleadoRepository();
                if (repoEmpleado.ExisteUsuario(usuario))
                {
                    MessageBox.Show("Ese usuario ya existe.");
                    return;
                }
                repoEmpleado.Registrar(nombre, "", email, dui, usuario, hash);
            }
            else
            {
                var repoUsuario = new UsuarioRepository();
                if (repoUsuario.ExisteUsuario(usuario))
                {
                    MessageBox.Show("Ese usuario ya existe.");
                    return;
                }
                repoUsuario.Registrar(nombre, email, usuario, hash);
            }

            MessageBox.Show("Registro exitoso.");
            { 
            Menu menu = new Menu();
            menu.Show();
            this.Close();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}