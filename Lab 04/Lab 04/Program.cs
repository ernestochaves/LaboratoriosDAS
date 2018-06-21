using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //El menu es un ciclo que lee de la consola una tecla, y ejecuta un codigo basado en el numero seleccionado. 
            //Reemplazar el texto con la llamada a la funcion correspondiente. 
            int opcion;
            do
            {

                opcion = DisplayMenu();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Aqui va la lista de vehiculos");
                        break;
                    case 2:
                        Console.WriteLine("Aqui piden el año y filtran");
                        break;
                    case 3:
                        Console.WriteLine("Aqui piden el id de un carro y muestran sus detalles");
                        break;
                    case 4:
                        Console.WriteLine("Aqui piden los datos de un carro y lo agregan.");
                        break;
                    default:
                        break;

                }
            } while (opcion != 5);

        }

        private static int DisplayMenu()
        {
            Console.Write(@"
                            SELECCIONE UNA OPCION DE LA LISTA
                              ----------------------------------
                              1. Listar los vehículos
                              2. Filtrar los vehículos por año
                              3. Obtener los detalles de un vehículo por ID
                              4. Agregar un vehículo
                              5. Salir
                              ----------------------------------
                                  ");

            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }

    }
}
