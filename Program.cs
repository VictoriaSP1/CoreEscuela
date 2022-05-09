using System.Runtime.InteropServices;
using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program  
    {
        static void Main (string[] args)
        {
           var engine = new EscuelaEngine();
           engine.Inicializar();
           Printer.WriteTitle("Bienvenidos a la escuela");

           ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");

            if (escuela?.Cursos != null) 
            {
                foreach (var Curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {Curso.Nombre}, Id {Curso.UniqueId}");
                }
            }
            
        }
    }
}

    

