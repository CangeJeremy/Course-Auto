using Course_Auto.Models;

namespace Course_Auto.Generators
{
    public class GenerateCars
    {
        public List<Cars> getCars()
        {
            Random rnd = new Random();

            GenerateDrivers gd = new GenerateDrivers();
            List<Drivers> drivers = gd.getDrivers();

            List<Cars> cars = new List<Cars>();
            foreach (Drivers driver in drivers)
            {
                Cars car = new Cars();
                car.Driver = driver;
                car.minSpeed = rnd.Next(1, 150);
                car.maxSpeed = rnd.Next(150, 351);
                cars.Add(car);
            }

            return cars;
        }
    }
}
