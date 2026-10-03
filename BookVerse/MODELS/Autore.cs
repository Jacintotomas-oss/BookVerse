using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Autore
{
    public int IdAutor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();

    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}
