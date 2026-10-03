using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Series
{
    public int IdSeries { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdAutor { get; set; }

    public virtual Autore? IdAutorNavigation { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
