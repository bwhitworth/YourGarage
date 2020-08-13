using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Vehicle
    {
        public int Fuel { get; set; } = 100;
        public int BatteryCapacity { get; set; } = 100;
        public string Color { get; set; }
        public int NumPassengers { get; set; }

        public void Refuel()
        {
            if (Fuel == 100)
            {
                Console.WriteLine("Your vehicle is already full of fuel.");
            }
            else
            {
                Fuel = 100;
                Console.WriteLine("You refueled the vehicle - the fuel tank is full.");
            }

        }

        public void Drive()
        {
            Fuel -= 20;
            Console.WriteLine($"You went for a drive and now have {Fuel}% fuel left");
        }
    }
}
