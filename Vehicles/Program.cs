using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
           // var carinput = Console.ReadLine().Split(' ');
           // var fuelAmount = double.Parse(carinput[1]);
           // var fuelConsumption = double.Parse(carinput[2]);
           // var tankCapacity = ParseTankCapacity(fuelAmount,double.Parse(carinput[3]));
           // IVehicle car = new Car(fuelAmount, fuelConsumption, tankCapacity);
           //
           // var truckInput = Console.ReadLine().Split(' ');
           // fuelAmount = double.Parse(truckInput[1]);
           // fuelConsumption = double.Parse(truckInput[2]);
           // tankCapacity = ParseTankCapacity(fuelAmount,double.Parse(truckInput[3]));
           // IVehicle truck = new Truck(fuelAmount, fuelConsumption,tankCapacity);
           //
           // var busInput = Console.ReadLine().Split(' ');
           // fuelAmount = double.Parse(busInput[1]);
           // fuelConsumption = double.Parse(busInput[2]);
           // tankCapacity = ParseTankCapacity(fuelAmount, double.Parse(busInput[3]));
           // Bus bus = new Bus(fuelAmount, fuelConsumption, tankCapacity);

            List<IVehicle> vehicles = new List<IVehicle>();
            for(int i = 0; i < 3; i++)
            {
                var inputTokens = Console.ReadLine().Split();
                var vehicleType = inputTokens[0];
                var passedFuel = double.Parse(inputTokens[1]);
                var vehicleConsumption = double.Parse(inputTokens[2]);
                var vehicleTankCapacity = double.Parse(inputTokens[3]);
                var vehicleFuel = ParseFuel(passedFuel, vehicleTankCapacity);
                IVehicle vehicle=null;
                switch (vehicleType)
                {
                    case "Car":
                        vehicle = new Car(vehicleFuel, vehicleConsumption, vehicleTankCapacity);
                        break;
                    case "Truck":
                        vehicle = new Truck(vehicleFuel, vehicleConsumption, vehicleTankCapacity);
                        break;
                    case "Bus":
                        vehicle = new Bus(vehicleFuel, vehicleConsumption, vehicleTankCapacity);
                        break;
                }

                vehicles.Add(vehicle);
            }

            var totalInputs = int.Parse(Console.ReadLine());
            Car car = (Car)vehicles.Find(v => v.GetType().Name == "Car");
            Truck truck = (Truck)vehicles.Find(v => v.GetType().Name == "Truck");
            Bus bus = (Bus)vehicles.Find(v => v.GetType().Name == "Bus");
            for (int i = 0; i< totalInputs; i++)
            {
                var inputLine = Console.ReadLine();
                var inputTokens = inputLine.Split(' ');
                var command = inputTokens[0];
                var vehicle = inputTokens[1];
                var distanceOrAmount = double.Parse(inputTokens[2]);
                if(command == "Refuel" && distanceOrAmount <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                    continue;
                }
                switch (command)
                {
                    case "Drive":
                        if(vehicle == "Car")
                        {
                            car.Drive(distanceOrAmount);
                        }
                        else if(vehicle == "Truck")
                        {
                            truck.Drive(distanceOrAmount);
                        }
                        else if(vehicle == "Bus")
                        {
                            bus.Drive(distanceOrAmount);
                        }
                        break;

                    case "Refuel":
                        if(vehicle == "Car")
                        {
                            car.Refuel(distanceOrAmount);
                        }
                        else if(vehicle == "Truck")
                        {
                            truck.Refuel(distanceOrAmount);
                        }
                        else if(vehicle == "Bus")
                        {
                            bus.Refuel(distanceOrAmount);
                        }
                        break;
                    case "DriveEmpty":
                        bus.DriveEmpty(distanceOrAmount);
                        break;
                }

            }
            
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        private static double ParseFuel(double fuelAmount, double capacity)
        {
            if(fuelAmount > capacity)
            {
                return 0;
            }
            else
            {
                return fuelAmount;
            }
        }
    }
}
