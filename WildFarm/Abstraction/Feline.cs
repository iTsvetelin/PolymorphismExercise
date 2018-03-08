using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Abstraction
{
    public abstract class Feline : Mamal
    {
        public Feline(string name, double weight, string liveRegion, string breed)
            : base(name, weight, liveRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            var animalType = this.GetType().Name;
            var result = $"{animalType} [{this.Name}, {this.Breed}, {this.Weight}, {this.LiveRegion}, {this.FoodEaten}]";

            return result;
        }
    }
}
