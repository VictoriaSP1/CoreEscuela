using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class Reporteador
    {

        //Por convención, se usa _atributoPrivado 
        //Para atributos del tipo privado
        Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;

        public Reporteador (
            Dictionary<LlavesDiccionario, 
            IEnumerable<ObjetoEscuelaBase>> diccionarioObjEscuela
            ) 
        {
            if (diccionarioObjEscuela == null)
            {
                throw new ArgumentNullException(nameof (diccionarioObjEscuela));
            }
            else 
            {
                _diccionario = diccionarioObjEscuela;
            }
        }

        public IEnumerable <Evaluacion> GetListaEvaluaciones ()
        {
            _diccionario[LlavesDiccionario.Evaluación]
        }
    }
}