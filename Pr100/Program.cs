using Pr100.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr100
{
    public delegate void RentEventHandler(object sender, EventArgs e);
    interface IRentable
    {
        string Model { get; }
        bool IsRented { get; set; }

        void PrintInfo();
        void Rent();

        event RentEventHandler RentEvent;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            List<ITransport> transports = new List<ITransport>();

            transports.Add(new Boat("187 km/h", "Blue", "Sea Ray", "Do not need", "Gas", true));
            transports.Add(new Boat("152 km/h", "White and Black", "Victory 570", "Do not need", "Gas", false));
            transports.Add(new Car("220 km/h", "Red", "Porsche 911", "B", "4", "Gas", true));
            transports.Add(new Car("190 km/h", "Black", "Mercedes-benz s-class", "B", "4", "Gas", true));
            transports.Add(new Bicycle("35 km/h", "Green and White", "Scott addict", "Be above 14 y.old", true));
            transports.Add(new Bicycle("15 km/h", "Blue and White", "Novatrack juster", "Be under 60 kg", false));
            transports.Add(new Motorcycle("160 km/h", "Black", "Harley davidson", "A", "2", "Gas", false));
            transports.Add(new Motorcycle("80 km/h", "Black and Deep Red", "Alrendo ts", "A", "2", "Electric", true));
            transports.Add(new Scooter("35 km/h", "Red", "Kugoo 3", "Be above 60 kg", "2", "Electric", false));
            transports.Add(new Scooter("40 km/h", "Yellow", "Xiaomi", "Be under 60 kg", "2", "Electric", false));

            Console.WriteLine("Company transport property:\n");

            foreach (ITransport transport in transports)
            {
                transport.PrintInfo();
            }
            string modelName = "";
            while (modelName != "exit")
            {
                Console.WriteLine("Enter the model of the transport you want to check if it is rented or not (or type 'exit' to exit):");
                modelName = Console.ReadLine();

                if (modelName != "exit")
                {
                    foreach (ITransport transport in transports)
                    {
                        if (transport.Model == modelName)
                        {
                            Console.WriteLine($"Transport: {modelName}, Is Rented: {(transport.IsRented)}");
                            if (transport.IsRented == false)
                            {
                                Console.WriteLine("Do you want to rent " + transport.Model + "?");
                                string Answer = Console.ReadLine();
                                if (Answer.ToLower() == "yes")
                                {
                                    Console.WriteLine(transport.Model + " has been rented by you");
                                    transport.IsRented = true;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, but " + transport.Model + " is already taken");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
