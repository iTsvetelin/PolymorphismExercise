using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        public Car(double fuelQuantity, double consumptionPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = consumptionPerKm + 0.9;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance)
        { 
            var totalFuel = this.FuelConsumption * distance;
            if(totalFuel > this.FuelQuantity)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                this.FuelQuantity -= totalFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
        }

        public void Refuel(double amount)
        {
            var tankSpace = this.TankCapacity - this.FuelQuantity;
            if(tankSpace < amount)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                return;
            }
            else
            {
                this.FuelQuantity += amount;
            }
        }

        public override string ToString()
        {
            var result = $"Car: {this.FuelQuantity:f2}";
            return result;
        }
    }
}
