using System;
using System.Collections.Generic;
using System.Text;
using Vehicles2.Contracts;

namespace Vehicles2
{
    public class Truck : Vehicle
    {
        private const double CONDITIONER_BONUS = 1.6;

        public Truck(double fuel, double consumption, double capacity) 
            : base(fuel, consumption, capacity, CONDITIONER_BONUS)
        {
        }

        public override void Refuel(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            double availableSpace = this.Capacity - this.Fuel;
            
            if (amount > availableSpace)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                double newAmonut = amount * 0.95;
                this.Fuel += newAmonut;
            }

        }
    }
}
