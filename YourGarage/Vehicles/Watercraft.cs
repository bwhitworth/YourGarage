using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Watercraft : Vehicle
    {
        public Watercraft(string color, int numOfPassengers)
        {
            Color = color;
            NumPassengers = numOfPassengers;
        }
    }
}
