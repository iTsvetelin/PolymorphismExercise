using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        public Truck(double fuelQuantity, double consumptionPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = consumptionPerKm + 1.6   ;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance)
        {
            var fuelNeeded = this.FuelConsumption * distance;
            if(fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }

        public void Refuel(double amount)
        {
            var tankSpace = this.TankCapacity - this.FuelQuantity;
            if (tankSpace < amount)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                double newAmount = 0.95d * amount;
                this.FuelQuantity += newAmount;
            }
        }

        public override string ToString()
        {
            var result = $"Truck: {this.FuelQuantity:f2}";
            return result;
        }
    }
}
