using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea (int tam = 10) 
        {
            WriteLine("".PadLeft(tam,'='));
        }

        public static void WriteTitle(string titulo) 
        {
            DibujarLinea(titulo.Length + 4);
            WriteLine(titulo);
            DibujarLinea(titulo.Length + 4);

        }
    }
}