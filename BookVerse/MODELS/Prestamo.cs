using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookVerse.Models
{
    public partial class Prestamo
    {
        public int IdPrestamo { get; set; }

        public int? IdLibro { get; set; }

        public DateOnly FechaPrestamo { get; set; }

        public DateOnly? FechaDevolucion { get; set; }

        public virtual Libro? IdLibroNavigation { get; set; }
        [MaxLength(100)]
        public string? NombrePrestatario { get; set; }

        [MaxLength(20)]
        public string? TelefonoPrestatario { get; set; }
    }
}