using Core;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new();

            gallery.AddCar(new Car(1, "BMW", 200, "M5"));
            gallery.AddCar(new Car(2, "Mercedes Benz", 150, "E-Class"));


            Console.WriteLine("\nId-e gore axtaris et:");
            var carById = gallery.FindCarById(2);
            if (carById != null)
            {
                Console.WriteLine($"Id: {carById.Id}, Name: {carById.Name}, Speed: {carById.Speed}, CarCode: {carById.CarCode}");
            }
            else
            {
                Console.WriteLine("Masin tapilmadi!");
            }
            Console.WriteLine("\nMasinin koduna gore axtaris et:");
            var carByCarCode = gallery.FindCarByCarCode("m5");
            if (carByCarCode != null)
            {
                Console.WriteLine($"Id: {carByCarCode.Id}, Name: {carByCarCode.Name}, Speed: {carByCarCode.Speed}, CarCode: {carByCarCode.CarCode}");
            }
            else
            {
                Console.WriteLine("Masin tapilmadi!");
            }
            Console.WriteLine("\nMasinlarin suretine gore axtaris et:");
            var carsBySpeed = gallery.FindCarsBySpeed(130, 160);
            foreach (var car in carsBySpeed)
            {
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
            }
        }
    }
}
