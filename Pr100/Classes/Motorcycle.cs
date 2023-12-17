using System;

namespace Pr100.Classes
{
    class Motorcycle : ITransport
    {
        public string Model { get; }
        public string Speed { get; }
        public string Color { get; }
        public string LicenseCategory { get; }
        public bool IsRented { get; set; }
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }

        public Motorcycle(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
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
            Console.WriteLine($"Motorcycle: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Number of Wheels: {NumberOfWheels}, Engine: {Engine}, Is Rented: {(IsRented ? "Yes" : "No")}");
        }
    }
}
