using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
