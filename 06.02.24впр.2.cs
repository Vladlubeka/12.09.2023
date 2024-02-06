using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Тварина виділяє звук");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " гавкає");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " муркоче");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Барбос");
            Cat cat = new Cat("Мурка");

            dog.MakeSound(); 
            cat.MakeSound(); 
        }
    }
}