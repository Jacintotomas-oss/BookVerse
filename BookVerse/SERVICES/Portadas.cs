using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BookVerse.Services
{
    public static class Portadas
    {
        private static string Carpeta => Path.Combine(Application.StartupPath, "Portadas");
        private static string RutaDe(int idLibro) => Path.Combine(Carpeta, idLibro + ".png");

        public static void Guardar(int idLibro, string rutaOrigen)
        {
            Directory.CreateDirectory(Carpeta);
            using (var img = Image.FromFile(rutaOrigen))
                img.Save(RutaDe(idLibro), ImageFormat.Png);
        }

        public static Image Cargar(int idLibro)
        {
            string ruta = RutaDe(idLibro);
            if (!File.Exists(ruta)) return null;
            using (var img = Image.FromFile(ruta))
                return new Bitmap(img);   // copia, para no bloquear el archivo
        }

        public static void Borrar(int idLibro)
        {
            string ruta = RutaDe(idLibro);
            if (File.Exists(ruta)) File.Delete(ruta);
        }
    }
}
