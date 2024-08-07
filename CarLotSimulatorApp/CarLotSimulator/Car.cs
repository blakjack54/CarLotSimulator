using System; // Ensure this is included

namespace CarLotSimulator
{
    public class Car
    {
        // Properties of the Car class
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }

        // Constructor to initialize Car properties and increment the car count
        public Car(string make, string model, int year, string color, bool isElectric)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            IsElectric = isElectric;
            
            // Increment the car count in CarLot
            CarLot.numberOfCars++;
        }

        // Method to display car information
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}, Electric: {IsElectric}");
        }
    }
}