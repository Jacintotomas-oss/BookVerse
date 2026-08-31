using BookVerse.MODELS;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookVerse.Models
{
    public class Libro
    {
        public int Id_Libro { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
        public Editorial Editorial { get; set; }
        public Serie Serie { get; set; }
        public int? NumeroSerie { get; set; }
        public string RutaPDF { get; set; }

        public string CompartirInformacion()
        {
            return $"ID_Libro: {Id_Libro}, Titulo: {Titulo}, Autor: {Autor?.Nombre}, " +
                   $"Categoria: {Categoria?.Nombre}, Serie: {Serie?.Nombre}, Numero: {NumeroSerie}";
        }
    }
}