using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookVerse.FORMS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLeer_Click_1(object sender, EventArgs e)
        {
            //definimos que al darle click al boton de leer se abra un pdf con el libro que se quiere leer
            string rutaPdf = Path.Combine(Application.StartupPath, "RutasPDF", "GOT.pdf");

            if (File.Exists(rutaPdf))
            {
                Process.Start(new ProcessStartInfo(rutaPdf) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Ruta no encontrada o no disponible");
            }
        }
    }
}
