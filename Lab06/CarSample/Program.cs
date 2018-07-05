using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //El menu es un ciclo que lee de la consola una tecla, y ejecuta un codigo basado en el numero seleccionado. 
            //Reemplazar el texto con la llamada a la funcion correspondiente. 
            ICarService service = new CarService();
            int opcion;
            do
            {

                opcion = DisplayMenu();
                switch (opcion)
                {
                    case 1:
                        Print(service.GetList());
                        break;
                    case 2:
                        {
                            int year = int.Parse(Console.ReadLine());
                            Print(service.FilterByYear(year));
                        }
                        break;
                    case 3:
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine(service.GetCar(id));
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Model");
                            string model = Console.ReadLine();
                            Console.WriteLine("Brand");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Year");
                            int year = int.Parse(Console.ReadLine());

                            service.AddCar(new Car(id, model, brand, year));

                            Print(service.GetList());
                        }
                        break;
                    default:
                        break;

                }
            } while (opcion != 5);

        }

        private static void Print(List<Car> result)
        {
            foreach (var item in result)
                Console.WriteLine(item);
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
