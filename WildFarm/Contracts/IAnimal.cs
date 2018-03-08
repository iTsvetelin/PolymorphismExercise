using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Contracts
{
    public interface IAnimal
    {
        string Name { get; }

        double Weight { get; set; }
                            
        int FoodEaten { get; set; }

        void ProduceSound();

        void Eat(IAnimal animal, string foodType, int foodQuantity);
    }
}
