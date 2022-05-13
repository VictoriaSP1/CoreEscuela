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

            foreach (var item in listaPromXAsig)
            {
                foreach (var alum in item.Value)
                {
                    
                }
            }

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

    

