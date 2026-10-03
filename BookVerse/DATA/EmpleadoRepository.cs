// EmpleadoRepository.cs
using System.Linq;
using BookVerse.Models;

namespace BookVerse.Data
{
    public class EmpleadoRepository
    {
        public bool ValidarLogin(string usuario, string contrasenaHash)
        {
            using (var contexto = new LibreriaContext())
                return contexto.Empleados.Any(e => e.Usuario == usuario && e.Contrasena == contrasenaHash);
        }

        public bool ExisteUsuario(string usuario)
        {
            using (var contexto = new LibreriaContext())
                return contexto.Empleados.Any(e => e.Usuario == usuario);
        }

        public void Registrar(Empleado empleado)
        {
            using (var contexto = new LibreriaContext())
            {
                contexto.Empleados.Add(empleado);
                contexto.SaveChanges();
            }
        }
    }
}