using System;
using System.Collections.Generic;
using System.Text;
using Vehicles2.Contracts;

namespace Vehicles2
{
    public class Bus : Vehicle
    {
        private const double CONDITIONER_BONUS = 1.4;

        public Bus(double fuel, double consumption, double capacity) 
            : base(fuel, consumption, capacity, CONDITIONER_BONUS)
        {
        }
    }
}
