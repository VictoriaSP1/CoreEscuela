using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine (int tam = 10) 
        {
            WriteLine("".PadLeft(tam,'='));
        }

        public static void WriteTitle(string titulo) 
        {
            DrawLine(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            DrawLine(titulo.Length + 4);

        }
    }
}