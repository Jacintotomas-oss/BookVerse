using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int? IdLibro { get; set; }

    public DateOnly FechaPrestamo { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

    public virtual Libro? IdLibroNavigation { get; set; }
}
