using System; // Ensure this is included

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new CarLot instance
            CarLot carLot = new CarLot();

            // Create the first car
            Car car1 = new Car("Toyota", "Corolla", 2021, "Red", false);
            carLot.AddCar(car1); // Add the car to the lot

            // Create the second car
            Car car2 = new Car("Ford", "Mustang", 2022, "Blue", false);
            carLot.AddCar(car2); // Add the car to the lot

            // Create the third car
            Car car3 = new Car("Tesla", "Model S", 2023, "White", true);
            carLot.AddCar(car3); // Add the car to the lot

            // Display all cars in the car lot
            Console.WriteLine("\nCars currently in the car lot:");
            foreach (Car car in carLot.Cars)
            {
                car.DisplayInfo();
            }

            // Display the final count of cars
            Console.WriteLine($"\nTotal number of cars in the car lot: {CarLot.numberOfCars}");
        }
    }
}