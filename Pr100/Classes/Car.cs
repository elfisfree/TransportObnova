using System;

namespace Pr100.Classes
{
    public class Car : ITransport
    {
        public string Model { get; }
        public string Speed { get; }
        public string Color { get; }
        public string LicenseCategory { get; }
        public bool IsRented { get; set; }
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }

        public Car(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
        {
            Speed = speed;
            Color = color;
            Model = model;
            LicenseCategory = licenseCategory;
            NumberOfWheels = numberOfWheels;
            Engine = engine;
            IsRented = isRented;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Car: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Is Rented: {(IsRented ? "Yes" : "No")}, Number of Wheels: {NumberOfWheels}");
        }
    }
}
