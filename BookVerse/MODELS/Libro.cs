using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public int? IdSeries { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdAutor { get; set; }

    public int? IdEditorial { get; set; }

    public int? NumeroSerie { get; set; }

    public string? RutaPdf { get; set; }

    public virtual Autore? IdAutorNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Editorial? IdEditorialNavigation { get; set; }

    public virtual Series? IdSeriesNavigation { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
