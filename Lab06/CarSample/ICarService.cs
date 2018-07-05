using System.Collections.Generic;

namespace CarSample
{
    public interface ICarService
    {
        List<Car> GetList();
        List<Car> FilterByYear(int year);
        Car GetCar(int id);
        void AddCar(Car car);
    }
}