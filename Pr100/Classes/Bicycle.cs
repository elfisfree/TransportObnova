using System;

namespace Pr100.Classes
{
    class Bicycle : ITransport
    {
        public string Model { get; }
        public string Speed { get; }
        public string Color { get; }
        public string LicenseCategory { get; }
        public bool IsRented { get; set; }

        public Bicycle(string speed, string color, string model, string licenseCategory, bool isRented)
        {
            Speed = speed;
            Color = color;
            Model = model;
            LicenseCategory = licenseCategory;
            IsRented = isRented;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Bicycle: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Is Rented: {(IsRented ? "Yes" : "No")}");
        }   
    }
}
