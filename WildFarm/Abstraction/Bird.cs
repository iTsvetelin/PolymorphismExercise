using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Abstraction;

namespace WildFarm.Abstraction
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            var typeName = this.GetType().Name;
            var result = $"{typeName} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";

            return result;
        }
    }
}
