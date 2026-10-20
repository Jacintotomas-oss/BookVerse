using System;
using System.Collections;
using System.Linq;
using BookVerse.Data;
using BookVerse.Models;

namespace BookVerse.DATA
{
    public class PrestamosRepository
    {
        // Libros ordenados por ID, con su estado y la fecha límite (1 mes)
        public IList ObtenerLibrosParaGrid()
        {
            using (var contexto = new LibreriaContext())
            {
                var libros = contexto.Libros
                    .OrderBy(l => l.IdLibro)
                    .Select(l => new { l.IdLibro, l.Titulo })
                    .ToList();

                var activos = contexto.Prestamos
                    .Where(p => p.FechaDevolucion == null)
                    .ToList();

                return libros.Select(l =>
                {
                    var prestamo = activos.FirstOrDefault(p => p.IdLibro == l.IdLibro);
                    return new
                    {
                        l.IdLibro,
                        l.Titulo,
                        Estado = prestamo == null ? "Disponible" : "Prestado",
                        Vence = prestamo == null ? "" : prestamo.FechaPrestamo.AddMonths(1).ToString("dd/MM/yyyy")
                    };
                }).ToList();
            }
        }

        public bool Prestar(int idLibro, out string mensaje)
        {
            using (var contexto = new LibreriaContext())
            {
                if (!contexto.Libros.Any(l => l.IdLibro == idLibro))
                {
                    mensaje = "El libro no existe.";
                    return false;
                }
                if (contexto.Prestamos.Any(p => p.IdLibro == idLibro && p.FechaDevolucion == null))
                {
                    mensaje = "Este libro ya está prestado.";
                    return false;
                }

                contexto.Prestamos.Add(new Prestamo
                {
                    IdLibro = idLibro,
                    FechaPrestamo = DateOnly.FromDateTime(DateTime.Today)
                });
                contexto.SaveChanges();

                mensaje = "Préstamo registrado. Fecha límite: " + DateTime.Today.AddMonths(1).ToString("dd/MM/yyyy");
                return true;
            }
        }

        public bool Devolver(int idLibro, out string mensaje)
        {
            using (var contexto = new LibreriaContext())
            {
                var prestamo = contexto.Prestamos
                    .FirstOrDefault(p => p.IdLibro == idLibro && p.FechaDevolucion == null);

                if (prestamo == null)
                {
                    mensaje = "Este libro no está prestado.";
                    return false;
                }

                prestamo.FechaDevolucion = DateOnly.FromDateTime(DateTime.Today);
                contexto.SaveChanges();

                mensaje = "Devolución registrada.";
                return true;
            }
        }
        public List<Libro> ObtenerLibros()
        {
            using (var contexto = new LibreriaContext())
            {
                return contexto.Libros.OrderBy(l => l.IdLibro).ToList();
            }
        }
    }
}