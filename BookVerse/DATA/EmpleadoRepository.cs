// EmpleadoRepository.cs
using BookVerse.DATA;
using Microsoft.Data.SqlClient;

namespace BookVerse.Data
{
    public class EmpleadoRepository
    {
        public bool ValidarLogin(string usuario, string contrasenaHash)
        {
            using (var conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string sql = "SELECT COUNT(*) FROM Empleado WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasenaHash);
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void Registrar(string nombre, string telefono, string email, string dui, string usuario, string contrasenaHash)
        {
            using (var conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string sql = @"INSERT INTO Empleado (Nombre, Telefono, Email, Dui, Usuario, Contrasena)
                               VALUES (@Nombre, @Telefono, @Email, @Dui, @Usuario, @Contrasena)";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Dui", dui);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasenaHash);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public bool ExisteUsuario(string usuario)
        {
            using (var conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string sql = "SELECT COUNT(*) FROM Empleado WHERE Usuario = @Usuario";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}