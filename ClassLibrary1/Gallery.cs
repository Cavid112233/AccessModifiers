using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Car> Cars { get; set; }

        public Gallery(int id, string name)
        {
            Id = id;
            Name = name;
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void ShowAllCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
            }
        }

        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById(int id)
        {
            foreach (var car in Cars)
            {
                if (car.Id == id)
                    return car;
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            foreach (var car in Cars)
            {
                if (car.CarCode == carCode.ToUpper())
                    return car;
            }
            return null;
        }

        public List<Car> FindCarsBySpeed(int minSpeed, int maxSpeed)
        {
            List<Car> result = new List<Car>();
            foreach (var car in Cars)
            {
                if (car.Speed >= minSpeed && car.Speed <= maxSpeed)
                    result.Add(car);
            }
            return result;
        }
    }
}
