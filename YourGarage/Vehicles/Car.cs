using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Car : Vehicle
    {
        public Car(string color, int numOfPassengers)
        {
            Color = color;
            NumPassengers = numOfPassengers;
        }

        public void Brake()
        {
            Console.WriteLine("You used the brakes to stop at a traffic light...");
        }
    }
}
