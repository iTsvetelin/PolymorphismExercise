using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Abstraction;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string liveRegion, string breed) 
            : base(name, weight, liveRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
