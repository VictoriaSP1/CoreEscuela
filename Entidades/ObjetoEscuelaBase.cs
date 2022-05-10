using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; }
        public string Nombre {  get; set; }

        public override string ToString ()
        {
            return $"{Nombre}, {UniqueId}";
        }

        public ObjetoEscuelaBase () {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}