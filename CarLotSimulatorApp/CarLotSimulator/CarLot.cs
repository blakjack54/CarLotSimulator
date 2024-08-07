using System; // Ensure this is included
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        // Static field to keep track of the number of cars
        public static int numberOfCars = 0;

        // List to store cars in the car lot
        public List<Car> Cars { get; set; } = new List<Car>();

        // Method to add a car to the lot
        public void AddCar(Car car)
        {
            Cars.Add(car);
            Console.WriteLine($"A new car has been added. Current number of cars: {numberOfCars}");
        }
    }
}