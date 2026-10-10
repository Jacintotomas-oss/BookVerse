using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BookVerse.Models;
using BookVerse.Data;
namespace BookVerse.DATA
{
    public class LibroRepository
    {
        public IList ObtenerParaGrid()
        {
            using (var contexto = new LibreriaContext())
                return contexto.Libros
                    .Select(l => new
                    {
                        l.IdLibro,
                        l.Titulo,
                        Autor = l.IdAutorNavigation.Nombre,
                        Editorial = l.IdEditorialNavigation.Nombre,
                        Categoria = l.IdCategoriaNavigation.NombreCategoria,
                        Serie = l.IdSeriesNavigation != null ? l.IdSeriesNavigation.Nombre : "",
                        l.NumeroSerie
                    })
                    .ToList();
        }
        public Libro ObtenerPorId(int id)
        {
            using (var contexto = new LibreriaContext())
            {
                return contexto.Libros.Find(id);
            }
        }
        public void agregar(Libro libro)
        {
            using (var contexto = new LibreriaContext())
            {
                contexto.Libros.Add(libro);
                contexto.SaveChanges();
            }
        } 
        //actualizar
        public void actualizar(Libro libro)
        {
            using (var contexto = new LibreriaContext())
            {
                var existente = contexto.Libros.Find(libro.IdLibro);
                if (existente == null)
                {
                    throw new Exception("Libro no encontrado");
                }
                existente.Titulo = libro.Titulo;
                existente.IdAutor = libro.IdAutor;
                existente.IdEditorial = libro.IdEditorial;
                existente.IdCategoria = libro.IdCategoria;
                existente.IdSeries = libro.IdSeries;
                existente.NumeroSerie = libro.NumeroSerie;
                existente.Descripcion = libro.Descripcion;
                contexto.SaveChanges();

            }
        }
        public void eliminar(Libro libro)
        {
            using(var contexto = new LibreriaContext())
            {
                var existente = contexto.Libros.Find(libro.IdLibro);
                if (existente == null)
                {
                    throw new Exception("Libro no encontrado");
                }
                contexto.Libros.Remove(libro);
                contexto.SaveChanges();
            }
        }
    }
}
