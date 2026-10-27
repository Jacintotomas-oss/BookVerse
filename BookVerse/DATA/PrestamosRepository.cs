using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BookVerse.Data;
using BookVerse.Models;

namespace BookVerse.DATA
{
    public class PrestamosRepository
    {
        // Libros ordenados por ID, con stock, ejemplares prestados/disponibles y fecha límite (1 mes)
        public IList ObtenerLibrosParaGrid()
        {
            using (var contexto = new LibreriaContext())
            {
                var libros = contexto.Libros
                    .OrderBy(l => l.IdLibro)
                    .Select(l => new { l.IdLibro, l.Titulo, l.Stock })
                    .ToList();

                var activos = contexto.Prestamos
                    .Where(p => p.FechaDevolucion == null)
                    .ToList();

                return libros.Select(l =>
                {
                    var deLibro = activos
                        .Where(p => p.IdLibro == l.IdLibro)
                        .OrderBy(p => p.FechaPrestamo)
                        .ToList();

                    int disponibles = l.Stock - deLibro.Count;

                    return new
                    {
                        l.IdLibro,
                        l.Titulo,
                        l.Stock,
                        Prestados = deLibro.Count,
                        Disponibles = disponibles,
                        Estado = disponibles > 0 ? "Disponible" : "Agotado",
                        // fecha límite del préstamo más antiguo (el próximo en volver)
                        Vence = deLibro.Count == 0 ? "" : deLibro[0].FechaPrestamo.AddMonths(1).ToString("dd/MM/yyyy")
                    };
                }).ToList();
            }
        }

        public bool Prestar(int idLibro, out string mensaje)
        {
            using (var contexto = new LibreriaContext())
            {
                var libro = contexto.Libros.Find(idLibro);
                if (libro == null)
                {
                    mensaje = "El libro no existe.";
                    return false;
                }

                int activos = contexto.Prestamos.Count(p => p.IdLibro == idLibro && p.FechaDevolucion == null);
                if (activos >= libro.Stock)
                {
                    mensaje = "No hay ejemplares disponibles.";
                    return false;
                }

                contexto.Prestamos.Add(new Prestamo
                {
                    IdLibro = idLibro,
                    FechaPrestamo = DateOnly.FromDateTime(DateTime.Today)
                });
                contexto.SaveChanges();

                mensaje = "Préstamo registrado. Quedan " + (libro.Stock - activos - 1) +
                          " ejemplares. Fecha límite: " + DateTime.Today.AddMonths(1).ToString("dd/MM/yyyy");
                return true;
            }
        }

        public bool Devolver(int idLibro, out string mensaje)
        {
            using (var contexto = new LibreriaContext())
            {
                // con varios ejemplares prestados, se devuelve el más antiguo
                var prestamo = contexto.Prestamos
                    .Where(p => p.IdLibro == idLibro && p.FechaDevolucion == null)
                    .OrderBy(p => p.FechaPrestamo).ThenBy(p => p.IdPrestamo)
                    .FirstOrDefault();

                if (prestamo == null)
                {
                    mensaje = "Este libro no tiene ejemplares prestados.";
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