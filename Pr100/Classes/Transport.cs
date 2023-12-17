using System;
using System.Collections.Generic;

namespace Pr100.Classes
{
    interface ITransport
    {
        string Model { get; }
        string Speed { get; }
        string Color { get; }
        string LicenseCategory { get; }
        bool IsRented { get; set; }

        void PrintInfo();
    }
    class Transport : IRentable
    {
        public string Model { get; }
        public bool IsRented { get; set; }

        public Transport(string model, bool isRented)
        {
            Model = model;
            IsRented = isRented;
        }

        public event RentEventHandler RentEvent;

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Model: {Model}, Is Rented: {IsRented}");
        }

        public void Rent()
        {
            if (!IsRented)
            {
                Console.WriteLine($"Do you want to rent {Model}? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine($"{Model} has been rented by you");
                    IsRented = true;
                }
            }
            else
            {
                Console.WriteLine($"Sorry, {Model} is already taken.");
            }
        }
    }
}