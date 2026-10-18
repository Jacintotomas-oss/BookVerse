using BookVerse.Data;
using BookVerse.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookVerse.DATA
{
    public class AutorRepository
    {
        public List<Autore> ObtenerTodos()
        {
            using (var contexto = new LibreriaContext())
            {
                return contexto.Autores.OrderBy(a => a.Nombre).ToList();
            }
        }
        public void Agregar(Autore autore)
        {
            using (var contexto = new LibreriaContext())
            {
                contexto.Autores.Add(autore);
                contexto.SaveChanges();
            }
        }
        public void Actualizar(Autore autore)
        {
            using (var contexto = new LibreriaContext())
            {
                contexto.Autores.Update(autore);
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Autore autore)
        {
            using (var contexto = new LibreriaContext())
            {
                contexto.Autores.Remove(autore);
                contexto.SaveChanges();
            }
        }
        public Autore ObtenerPorId(int id)
        {
            using (var contexto = new LibreriaContext())
            {
                return contexto.Autores.Find(id);
            }
        }

    }
}
