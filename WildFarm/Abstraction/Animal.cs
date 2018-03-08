using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Abstraction
{
    public abstract class Animal : IAnimal
    {
        private static Dictionary<string, string> animalsEatingFood = new Dictionary<string, string>
        {
            {"Mouse",  "Vegetable,Fruit"} ,
            {"Cat", "Vegetable,Meat"},
            {"Tiger","Meat" },
            {"Dog", "Meat" },
            {"Owl", "Meat" }
        };

        private static Dictionary<string, double> animalsWeightPerUnit = new Dictionary<string, double>
        {
            {"Hen", 0.35 },
            {"Owl", 0.25},
            {"Mouse", 0.10 },
            {"Cat", 0.30 },
            {"Dog", 0.40 },
            {"Tiger", 1.00 }
        };

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public  void Eat(IAnimal animal, string foodType, int foodQuantity)
        {
            var animalType = animal.GetType().Name;
            var fatPerFood = animalsWeightPerUnit[animalType];
            var totalWeight = fatPerFood * foodQuantity;
            switch (animalType)
            {
                case "Hen":
                    animal.Weight += totalWeight;
                    animal.FoodEaten+= foodQuantity;
                    break;
                case "Owl":
                    OnlyMeatEatable(animalType, foodType, animal, totalWeight, foodQuantity);
                    break;
                case "Mouse":
                    if (foodType != "Vegetable" && foodType != "Fruit")
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }
                    else
                    {
                        animal.Weight += totalWeight;

                        animal.FoodEaten+= foodQuantity;
                    }
                    break;
                case "Cat":
                    if (foodType != "Vegetable" && foodType != "Meat")
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }
                    else
                    {
                        animal.Weight += totalWeight;
                        animal.FoodEaten+= foodQuantity;
                    }
                    break;
                case "Dog":
                    OnlyMeatEatable(animalType, foodType, animal, totalWeight,foodQuantity);
                    break;
                case "Tiger":
                    OnlyMeatEatable(animalType, foodType, animal, totalWeight, foodQuantity);
                    break;
            }


        }

        private void OnlyMeatEatable(string animalType, string foodType, IAnimal animal, double totalWeight, int foodQuantity)
        {
            if (foodType != "Meat")
            {
                Console.WriteLine($"{animalType} does not eat {foodType}!");
            }
            else
            {
                animal.Weight += totalWeight;
                animal.FoodEaten+= foodQuantity;
            }
        }

        public abstract void ProduceSound();
    }
}
