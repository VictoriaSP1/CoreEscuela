
using CoreEscuela.Util;

namespace CoreEscuela.Entidades 
{
    public class Escuela: ObjetoEscuelaBase, ILugar
    {
        public int AnioDeCreacion {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        private TiposEscuela TipoEscuela { get; set; }
        public List <Curso> Cursos { get; set; }
        public string Direccion { get; set; }

        public Escuela (string nombre,
                        int anio) => 
                        (Nombre, AnioDeCreacion) = 
                        (nombre, anio);

        public Escuela (string nombre, int anio, 
                        TiposEscuela tipo, 
                        string pais="", string ciudad = "")
        {
            (Nombre, AnioDeCreacion) = (nombre, anio);
            this.Pais = pais;
            this.Ciudad = ciudad; 
        }

        public override string ToString ()
        {
            return $"Nombre: \"{Nombre}\", Tipo: \"{TipoEscuela}\" \n Pais: \"{Pais}\", Ciudad: \"{Ciudad}\"";
        }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando establecimiento");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            Printer.WriteTitle($"Escuela {Nombre} está limpio");
        }
    }
}