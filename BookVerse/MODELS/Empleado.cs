using System;
using System.Collections.Generic;

namespace BookVerse.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Email { get; set; } = null!;

    public string Dui { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;
}
