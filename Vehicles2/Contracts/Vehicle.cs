using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles2.Contracts
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuel, double consumption, double capacity,double conditionerBonus)
        {
            this.Fuel = ParseFuel(fuel,capacity);
            this.Consumption = consumption;
            this.Capacity = capacity;
            this.ConditionerBonus = conditionerBonus;
        }

        private double ParseFuel(double fuel, double capacity)
        {
            if(fuel > capacity)
            {
                return 0;
            }
            else
            {
                return fuel;
            }
        }

        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public double Capacity { get; set; }
        public double ConditionerBonus { get; set; }

        public void Drive(double distance, bool empty)
        {
            double neededFuel;
            string typeName = this.GetType().Name;
            if (empty)
            {
                neededFuel = this.Consumption * distance;
            }
            else
            {
                neededFuel = (this.Consumption + this.ConditionerBonus) * distance;
            }

            if(neededFuel > this.Fuel)
            {
                Console.WriteLine($"{typeName} needs refueling");
            }
            else
            {
                this.Fuel -= neededFuel;
                Console.WriteLine($"{typeName} travelled {distance} km");
            }
        }

        public virtual void Refuel(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
                return;
            }
            double availableSpace = this.Capacity - this.Fuel;
            if(amount > availableSpace)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                this.Fuel += amount;
            }
        }

        public override string ToString()
        {
            var typeName = this.GetType().Name;
            var result = $"{typeName}: {this.Fuel:f2}";
            return result;
        }
    }
}
