using System;

namespace EjemploPolimorfismo
{
    public class Persona
    {

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }


        /// <summary>
        /// La palabra virtual hace posible sobreescribir el metodo en las clases hijas de forma correcta. 
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerNombre()
        {
            return Nombre + Apellidos;
        }
    }
}