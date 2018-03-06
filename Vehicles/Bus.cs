using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : IVehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance)
        {
            double totalConsumption = this.FuelConsumption + 1.4;
            var fuelNeeded = totalConsumption * distance; 
            if(fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                this.FuelQuantity-= fuelNeeded;
                Console.WriteLine($"Bus travelled {distance} km");
            }
        }

        public void DriveEmpty(double distance)
        {
            var fuelNeeded = this.FuelConsumption * distance;
            if(fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                this.TankCapacity -= fuelNeeded;
                Console.WriteLine($"Bus travelled {distance} km");
            }
        }

        public void Refuel(double amount)
        {
            double tankSpace = this.TankCapacity - this.FuelQuantity;
            if(amount > tankSpace)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += amount;
            }
        }

        public override string ToString()
        {
            var result = $"Bus: {this.FuelQuantity:f2}";
            return result;
        }
    }
}
