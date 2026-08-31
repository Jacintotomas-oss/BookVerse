using System;
using System.Collections.Generic;
using System.Text;

namespace BookVerse.MODELS
{
    public class Serie
    {
        public int Id_Serie { get; set; }
        public string Nombre { get; set; }

        public Autor Autor { get; set; }
    }
}
