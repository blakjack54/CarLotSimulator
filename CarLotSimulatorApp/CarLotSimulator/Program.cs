using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the CarLot
            CarLot carLot = new CarLot();

            // Create the first car using object initializer syntax
            Car car1 = new Car
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Corolla",
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = true
            };

            // Create the second car using constructor initialization
            Car car2 = new Car();
            car2.Year = 2019;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Vroom Vroom";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = true;

            // Create the third car using property setters
            Car car3 = new Car();
            car3.Year = 2021;
            car3.Make = "Ford";
            car3.Model = "Focus";
            car3.EngineNoise = "Zoom";
            car3.HonkNoise = "Honk Honk";
            car3.IsDriveable = true;

            // Add the cars to the car lot
            carLot.Cars.Add(car1);
            carLot.Cars.Add(car2);
            carLot.Cars.Add(car3);

            // Call the methods for each car
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            // Iterate through the list and print each car's details
            Console.WriteLine("Cars in the lot:");
            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
