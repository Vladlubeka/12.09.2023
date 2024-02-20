using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public interface IAnimal
    {
        void Voice();
        void Eat();
    }

    public abstract class Mammal : IAnimal
    {
        public string FoodType { get; set; }
        public void Voice()
        {
            Console.WriteLine("Какой-то звук млекопитающего ");
        }

        public void Eat()
        {
            Console.WriteLine("The mammal is eating " + FoodType);
        }
    }

    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.FoodType = "bones";

            dog.Voice();
            dog.Eat();
            dog.Bark();
        }
    }
}
