using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Un en objetos que heredan de otros, un metodo se comporta de acuerdo al tipo en tiempo de ejecucion. 
            //Por ejemplo, el metodo en persona es diferente al metodo en estudiante. 
            Persona persona = new Persona("Juan", "Perez");
            Console.WriteLine(persona.ObtenerNombre());
            //Y el metodo se elije de acuerdo al tipo de la variable.. 
            Estudiante estudiante = new Estudiante("Juan", "Perez", "A21355");
            Console.WriteLine(estudiante.ObtenerNombre());



            //2. Otro caso al que se puede tomar como polimorfismo es cuando la misma clase tiene metodos con el mismo nombre, 
            //pero con diferente signatura (cantidad y tipo de parametros)
            ServicioTransacciones st = new ServicioTransacciones();

            Console.WriteLine("Todas");
            var todas = st.ObtenerTransacciones();
            todas.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Del dia de hoy");
            var diarias = st.ObtenerTransacciones(DateTime.Now);
            diarias.ForEach(t => Console.WriteLine(t));

            Console.ReadLine();

        }
    }
}
