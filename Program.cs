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
            int dummy = 0;
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");

            ImprimirCursosEscuela(engine.Escuela);
            
            Dictionary <int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(10, "JuanK");
            diccionario.Add(23, "Lorem Ipsum");

            foreach (var keyValPair in diccionario)
            {
                WriteLine($"Key: {keyValPair.Key} Valor: {keyValPair.Value}");
            }

            Printer.WriteTitle("Acesso a diccionario");
            WriteLine(diccionario[23]);
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

    

