using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BookVerse.Data;
using BookVerse.Models;
using System.IO;
using QuestPDF; //esto ayuda al PDF creo yo 

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
        private const int UmbralStockBajo = 1;   // "stock bajo" = 1 o menos ejemplares disponibles

        public ReporteInventario GenerarReporte()
        {
            using (var contexto = new LibreriaContext())
            {
                var libros = contexto.Libros
                    .OrderBy(l => l.Titulo)
                    .Select(l => new { l.IdLibro, l.Titulo, l.Stock })
                    .ToList();
                var activos = contexto.Prestamos.Where(p => p.FechaDevolucion == null).ToList();

                var estado = libros.Select(l =>
                {
                    var deLibro = activos.Where(p => p.IdLibro == l.IdLibro).OrderBy(p => p.FechaPrestamo).ToList();
                    return new
                    {
                        l.Titulo,
                        l.Stock,
                        Prestados = deLibro.Count,
                        Disponibles = l.Stock - deLibro.Count,
                        Vence = deLibro.Count == 0 ? "" : deLibro[0].FechaPrestamo.AddMonths(1).ToString("dd/MM/yyyy")
                    };
                }).ToList();

                return new ReporteInventario
                {
                    Prestados = estado.Where(x => x.Prestados > 0)
                                      .Select(x => (x.Titulo, x.Prestados, x.Vence)).ToList(),
                    StockBajo = estado.Where(x => x.Disponibles <= UmbralStockBajo)
                                      .Select(x => (x.Titulo, x.Stock, x.Disponibles)).ToList(),
                    Disponibles = estado.Where(x => x.Disponibles > 0)
                                        .Select(x => (x.Titulo, x.Disponibles, x.Stock)).ToList()
                };
            }
        }

        // Crea la carpeta en Documentos\BookVerse\Reportes y devuelve la ruta del PDF.
        // CreateDirectory solo la crea la primera vez; si ya existe, no hace nada.
        public string RutaReporte()
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BookVerse", "Reportes");
            Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, "Reporte_Inventario.pdf");
        }
    }
    public class ReporteInventario
    {
        public List<(string Titulo, int Prestados, string Vence)> Prestados { get; set; }
        public List<(string Titulo, int Stock, int Disponibles)> StockBajo { get; set; }
        public List<(string Titulo, int Disponibles, int Stock)> Disponibles { get; set; }

        // Las tres secciones del reporte, listas para dibujar
        public List<(string Titulo, List<string> Lineas)> Secciones() => new List<(string, List<string>)>
    {
        ("Libros prestados",
            Prestados.Select(x => $"{x.Titulo}: {x.Prestados} prestado(s) — vence {x.Vence}").ToList()),
        ("Stock bajo",
            StockBajo.Select(x => $"{x.Titulo}: {x.Disponibles} disponibles de {x.Stock}").ToList()),
        ("Libros disponibles",
            Disponibles.Select(x => $"{x.Titulo}: {x.Disponibles} de {x.Stock}").ToList())
    };
    }
}