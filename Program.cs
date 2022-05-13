using System.Runtime.InteropServices;
using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using CoreEscuela.App;
using static System.Console;

namespace CoreEscuela
{
    class Program  
    {
        private static void AccionDelEvento(object sender, EventArgs e)
        {
            Printer.WriteTitle("SALIENDO");
            Printer.WriteTitle("SALIÓ");
        }


        static void Main (string[] args, EventHandler accionDelEvento)
        {
            AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;

            var engine = new EscuelaEngine();
            int dummy = 0;
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");

            //var reporteador = new Reporteador (engine.GetDiccionarioObjetos());
            var reporteador = new Reporteador (null);
            var evalList = reporteador.GetListaEvaluaciones();
            var listaAsg = reporteador.GetListaAsignaturas();
            var listaPromXAsig = reporteador.GetPromeAlumnPorAsignatura();

            Printer.WriteTitle("Captura de una Evaluación por Consola");
            var newEval = new Evaluacion();
            string nombre, notastring;
            float nota;

            WriteLine("Ingrese el nombre de la evaluación");
            Printer.PresioneENTER();
            nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Printer.WriteTitle("El valor del nombre no puede ser vacio");
                WriteLine("Saliendo del programa");
            }
            else
            {
                newEval.Nombre = nombre.ToLower();
                WriteLine("El nombre de la evaluacion ha sido ingresado correctamente");
            }


            WriteLine("Ingrese la nota de la evaluación");
            Printer.PresioneENTER();
            notastring = Console.ReadLine();


            try
            {
                newEval.Nota = float.Parse(notastring);
                if (newEval.Nota < 0 || newEval.Nota > 5)
                {
                    throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 5");
                }
                WriteLine("La nota de la evaluacion ha sido ingresada correctamente");
                return;
            }
            catch (ArgumentOutOfRangeException arge)
            {
                Printer.WriteTitle(arge.Message);
                WriteLine("Saliendo del programa");
            }
            finally
            {
                Printer.WriteTitle("FINALLY");
            }
            // catch(Exception)
            // {
            //     Printer.WriteTitle("El valor de la nota no es un número válido");
            //     WriteLine("Saliendo del programa");


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

    

