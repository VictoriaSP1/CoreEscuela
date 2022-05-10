using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso: ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }

        public List <Asignatura> Asignaturas {  get; set;   }

        public List <Alumno> Alumnos {  get; set;   }
        
    }
}