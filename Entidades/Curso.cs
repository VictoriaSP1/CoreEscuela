using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Util;

namespace CoreEscuela.Entidades
{
    public class Curso: ObjetoEscuelaBase, ILugar
    {
        public TiposJornada Jornada { get; set; }

        public List <Asignatura> Asignaturas {  get; set;   }

        public List <Alumno> Alumnos {  get; set;   }
        public string Direccion { get; set; }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando curso");
            Console.WriteLine($"Curso {Nombre} está limpio");
        }
    }
}