using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Abstraction
{
    public abstract class Mamal : Animal
    {
        public Mamal(string name, double weight, string liveRegion)
            : base(name, weight)
        {
            this.LiveRegion = liveRegion;
        }
        public string LiveRegion { get; set; }

        public override string ToString()
        {
            var typeName = this.GetType().Name;
            var result = $"{typeName} [{this.Name}, {this.Weight}, {this.LiveRegion}, {this.FoodEaten}]";

            return result;
        }

    }
}
