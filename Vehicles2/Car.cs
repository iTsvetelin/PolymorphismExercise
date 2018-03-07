using System;
using System.Collections.Generic;
using System.Text;
using Vehicles2.Contracts;

namespace Vehicles2
{
    public class Car : Vehicle
    {
        private const double CONDITIONER_BONUS = 0.9;

        public Car(double fuel, double consumption, double capacity)
            : base(fuel, consumption, capacity, CONDITIONER_BONUS)
        {
        }
    }
}
