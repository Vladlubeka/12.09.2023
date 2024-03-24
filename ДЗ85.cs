using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Chair
    {
        public int Number { get; set; }
        public string Color { get; set; }
        public string PersonName { get; set; }

        public Chair(int number, string color, string personName)
        {
            Number = number;
            Color = color;
            PersonName = personName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Chair> chairs = GenerateChairs();

            chairs = chairs.OrderBy(c => c.Color).ThenBy(c => c.PersonName).ToList();

            Console.WriteLine("Відсортовані стільці:");
            foreach (var chair in chairs)
            {
                Console.WriteLine($"Номер: {chair.Number}, Колір: {chair.Color}, Людина: {chair.PersonName}");
            }

            Console.ReadLine();
        }

        static List<Chair> GenerateChairs()
        {
            List<Chair> chairs = new List<Chair>();

            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                string color = GetRandomColor(random);
                string personName = GetRandomPersonName(random);
                chairs.Add(new Chair(i, color, personName));
            }

            return chairs;
        }

        static string GetRandomColor(Random random)
        {
            string[] colors = { "Червоний", "Зелений", "Синій" };
            return colors[random.Next(0, 3)];
        }

        static string GetRandomPersonName(Random random)
        {
            string[] names = { "Максим", "Іван", "Сергій" };
            return names[random.Next(0, 3)];
        }
    }
}
