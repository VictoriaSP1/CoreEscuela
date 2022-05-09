
namespace CoreEscuela.Entidades 
{
    public class Escuela 
    {
        public string UniqueId {    get; private set;   } = Guid.NewGuid().ToString();
        string nombre; 
        public string Nombre {
            get {   return "Copia:" + nombre; }
            set {   nombre = value.ToUpper(); }
        }
        public int AnioDeCreacion {get; set;}

        public string Pais { get; set; }
        
        public string Ciudad { get; set; }
        
        private TiposEscuela TipoEscuela { get; set; }

        public List <Curso> Cursos { get; set; }


        //Constructor, también puede hacerse de la forma habitual
        /*
        public Escuela (string nombre, int anio)
        {
            this.nombre=nombre;
            this.AnioDeCreacion=anio;
        }
        */
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
    }
}