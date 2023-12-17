using System;

namespace Pr100.Classes
{
    class Boat : ITransport
    {
        public string Model { get; }
        public string Speed { get; }
        public string Color { get; }
        public string LicenseCategory { get; }
        public bool IsRented { get; set; }
        public string Engine { get; set; }

        public Boat(string speed, string color, string model, string licenseCategory, string engine, bool isRented)
        {
            Speed = speed;
            Color = color;
            Model = model;
            LicenseCategory = licenseCategory;
            Engine = engine;
            IsRented = isRented;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Boat: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Is Rented: {(IsRented ? "Yes" : "No")}, Engine: {Engine}");
        }
    }
}

