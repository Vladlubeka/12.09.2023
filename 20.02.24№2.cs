using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        void MakeSound();
        void Eat();
    }

    public abstract class Mammal : IAnimal
    {
        public string FoodType { get; set; }

        public abstract void MakeSound();
        public abstract void Eat();
    }

    public class Dog : Mammal
    {
        public Dog()
        {
            FoodType = "М'ясо";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }

        public override void Eat()
        {
            Console.WriteLine("Собака їсть " + FoodType);
        }
    }

    public class Cat : Mammal
    {
        public Cat()
        {
            FoodType = "Риба";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Мяу!");
        }

        public override void Eat()
        {
            Console.WriteLine("Кіт їсть " + FoodType);
        }
    }

    public class Elephant : Mammal
    {
        public Elephant()
        {
            FoodType = "Трава";
        }

        public override void MakeSound()
        {
            Console.WriteLine("У-у-у!");
        }

        public override void Eat()
        {
            Console.WriteLine("Слон їсть " + FoodType);
        }
    }

    class Zoo
    {
        private List<Mammal> animals = new List<Mammal>();

        public void AddAnimal(Mammal animal)
        {
            animals.Add(animal);
        }

        public void DisplayAnimals()
        {
            Console.WriteLine("Тварини в зоопарку:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
            }
        }

        public void InteractWithAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("Взаємодія з " + animal.GetType().Name + ":");
                animal.MakeSound();
                animal.Eat();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.AddAnimal(new Dog());
            zoo.AddAnimal(new Cat());
            zoo.AddAnimal(new Elephant());

            zoo.DisplayAnimals();
            Console.WriteLine();
            zoo.InteractWithAnimals();
        }
    }
}
