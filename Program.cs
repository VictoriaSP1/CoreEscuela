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
            diccionario [0] = "Estoy en la posición 0";
            WriteLine(diccionario[0]);
            
            Printer.WriteTitle("Otro diccionario");
            var dic = new Dictionary<string, string>();
            dic ["Luna"] = "Cuerpo celeste";
            WriteLine (dic["Luna"]);
            dic ["Luna"] = "Protagonista de \"Soy Luna\"";
            //dic.add("Luna", "Protagonista de...") //es inválido en este caso
            //ya que el programa lo toma como si quisiera agregarle un nuevo
            //índice llamado Luna, a pesar de que solo requiero ponerle otro
            //significado
            WriteLine (dic["Luna"]);
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

    

