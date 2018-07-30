namespace EjemploPolimorfismo
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre, string apellido, string carnet) : base(nombre, apellido)
        {
            this.Carnet = carnet;
        }

        public string Carnet { get; set; }

        /// <summary>
        /// La palabra override hace que el hijo sobreescriba el metodo de la clase padre. virtual/override son necesarios p[ara implementar polimorfismo en clases heredadas. 
        /// </summary>
        /// <returns></returns>
        public override string ObtenerNombre()
        {
            return Carnet;
        }
    }
}