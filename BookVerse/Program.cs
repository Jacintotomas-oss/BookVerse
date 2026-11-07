using System;
using System.Windows.Forms;
using BookVerse.FORMS;
using BookVerse.Data;

namespace BookVerse
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenuPrincipal());
           // DbInitializer.Inicializar();
            Application.Run(new Login());
        } 
    }
}


//migracion a entity framework 