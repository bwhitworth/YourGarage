using System;
using System.Collections.Generic;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            var Boeing737 = new Aircraft("blue", 150);
            var JumboJet = new Aircraft("grey", 225);
            var UFO = new Aircraft("shiny", 1);

            List<Aircraft> FlyingVehicles = new List<Aircraft>();

            FlyingVehicles.Add(Boeing737);
            FlyingVehicles.Add(JumboJet);
            FlyingVehicles.Add(UFO);

            // With a single `foreach`, have each vehicle Fly()
            foreach (Aircraft plane in FlyingVehicles)
            {
                plane.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            var Camaro = new Car("red", 2);
            var Mustang = new Car("black", 4);
            var Corvette = new Car("grey", 2);

            List<Car> DrivingVehicles = new List<Car>();

            DrivingVehicles.Add(Camaro);
            DrivingVehicles.Add(Mustang);
            DrivingVehicles.Add(Corvette);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (Car car in DrivingVehicles)
            {
                car.Drive();
            }

            // Build a collection of all vehicles that operate on water
            var Tugboat = new Watercraft("black", 4);
            var Speedboat = new Watercraft("green", 3);
            var Fishingboat = new Watercraft("silver", 15);

            List<Watercraft> WaterVehicles = new List<Watercraft>();

            WaterVehicles.Add(Tugboat);
            WaterVehicles.Add(Speedboat);
            WaterVehicles.Add(Fishingboat);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (Watercraft boat in WaterVehicles)
            {
                boat.Drive();
            }
        }
    }
}
