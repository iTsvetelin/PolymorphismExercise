using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Abstraction;

namespace WildFarm.Models
{
    public class Dog : Mamal

    {
        public Dog(string name, double weight, string liveRegion) 
            : base(name, weight, liveRegion)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
