// Services/Seguridad.cs
using System.Security.Cryptography;
using System.Text;

namespace BookVerse.Services
{
    public static class Seguridad
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        // Método auxiliar seguro: Formatear correos electrónicos
        public static string NormalizarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return string.Empty;

            return correo.Trim().ToLower();
        }
    }
}