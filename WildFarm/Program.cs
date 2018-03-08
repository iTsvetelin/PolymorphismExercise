using System;
using System.Collections.Generic;
using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            List<IAnimal> animals = new List<IAnimal>();

            while((input = Console.ReadLine()) != "End")
            {
                var inputTokens = input.Split();


                //ParseAnimal start
                var animalType = inputTokens[0];
                var animalName = inputTokens[1];
                var animalWeight = double.Parse(inputTokens[2]);
                double wingSize = 0;
                string livingRegion = String.Empty;
                string breed = String.Empty;
                IAnimal animal = null;
                
                switch (animalType)
                {
                    case "Owl":
                        wingSize = double.Parse(inputTokens[3]);
                        animal = new Owl(animalName, animalWeight, wingSize);
                        break;
                    case "Hen":
                        wingSize = double.Parse(inputTokens[3]);
                        animal = new Hen(animalName, animalWeight, wingSize);
                        break;
                    case "Mouse":
                        livingRegion = inputTokens[3];
                        animal = new Mouse(animalName, animalWeight, livingRegion);
                        break;
                    case "Dog":
                        livingRegion = inputTokens[3];
                        animal = new Dog(animalName, animalWeight, livingRegion);
                        break;
                    case "Cat":
                        livingRegion = inputTokens[3];
                        breed = inputTokens[4];
                        animal = new Cat(animalName, animalWeight, livingRegion, breed);
                        break;
                    case "Tiger":
                        livingRegion = inputTokens[3];
                        breed = inputTokens[4];
                        animal = new Tiger(animalName, animalWeight, livingRegion, breed);
                        break;
                }
                animals.Add(animal);
                //ParseAnimal end

                //ParseFood start
                var foodTokens = Console.ReadLine().Split();
                var foodType = foodTokens[0];
                var foodQuantity = int.Parse(foodTokens[1]);

                animal.ProduceSound();
                animal.Eat(animal, foodType, foodQuantity);

                //ParseFood end
            }
            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
