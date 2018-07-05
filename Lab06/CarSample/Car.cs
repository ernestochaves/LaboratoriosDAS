namespace CarSample
{
    public class Car
    {
        public Car(int id, string model, string brand, int year)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0}, Model:{1}, Brand:{2}, Year:{3}",
                Id, Model, Brand, Year);
        }
    }
}