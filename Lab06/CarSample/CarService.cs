using System.Collections.Generic;

namespace CarSample
{
    public class CarService : ICarService
    {
        List<Car> cars = new List<Car>() {
            new Car(1, "Sentra", "Nissan", 2018),
            new Car(2, "Corolla", "Toyota", 2000)
        };

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public List<Car> FilterByYear(int year)
        {
            List<Car> results = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Year == year)
                    results.Add(cars[i]);

            }

            return results;
        }

        public Car GetCar(int id)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == id)
                    return cars[i];

            }
            return null;
        }

        public List<Car> GetList()
        {
            return cars;
        }
    }
}