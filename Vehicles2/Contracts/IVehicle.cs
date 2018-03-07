using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles2.Contracts
{
    public interface IVehicle
    {
        double Fuel { get; set; }

        double Consumption { get; set; }

        double Capacity { get; set; }

        double ConditionerBonus { get; set; }

        void Drive(double distance, bool empty);


        void Refuel(double amount);
    }
}
