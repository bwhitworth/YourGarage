using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft : Vehicle
    {
        public Aircraft(string color, int numOfPassengers)
        {
            Color = color;
            NumPassengers = numOfPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Color} aircraft flew across the sky.");
        }
    }
}
