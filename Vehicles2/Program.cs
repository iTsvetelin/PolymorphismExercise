using System;
using Vehicles2.Contracts;

namespace Vehicles2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var fuel = double.Parse(input[1]);
            var consumption = double.Parse(input[2]);
            var capacity = double.Parse(input[3]);
            IVehicle car = new Car(fuel, consumption, capacity);

            input = Console.ReadLine().Split();
            fuel = double.Parse(input[1]);
            consumption = double.Parse(input[2]);
            capacity = double.Parse(input[3]);
            IVehicle truck = new Truck(fuel, consumption, capacity);

            input = Console.ReadLine().Split();
            fuel = double.Parse(input[1]);
            consumption = double.Parse(input[2]);
            capacity = double.Parse(input[3]);
            IVehicle bus = new Bus(fuel, consumption, capacity);

            var numOfCommands = int.Parse(Console.ReadLine());

            for(int i = 0; i< numOfCommands; i++)
            {
                input = Console.ReadLine().Split();
                var command = input[0];
                var vehicleType = input[1];
                var amountOrDistance = double.Parse(input[2]);
                switch (command)
                {
                    case "Drive":
                        switch(vehicleType)
                        {
                            case "Car":
                                car.Drive(amountOrDistance, false);
                                break;
                            case "Truck":
                                truck.Drive(amountOrDistance, false);
                                break;
                            case "Bus":
                                bus.Drive(amountOrDistance, false);
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (vehicleType)
                        {
                            case "Car":
                                car.Refuel(amountOrDistance);
                                break;
                            case "Truck":
                                truck.Refuel(amountOrDistance);
                                break;
                            case "Bus":
                                bus.Refuel(amountOrDistance);
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        bus.Drive(amountOrDistance, true);
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
