using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
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
            ArrangeChairs(chairs);
            Console.WriteLine("Arranged Chairs:");
            foreach (var chair in chairs)
            {
                Console.WriteLine($"Chair {chair.Number}: Color - {chair.Color}, Person - {chair.PersonName}");
            }
        }

        static List<Chair> GenerateChairs()
        {
            List<Chair> chairs = new List<Chair>();
            Random random = new Random();
            string[] colors = { "Red", "Green", "Blue" };
            string[] names = { "Maxim", "Ivan", "Sergey" };

            for (int i = 1; i <= 10; i++)
            {
                string color = colors[random.Next(0, 3)];
                string name = names[random.Next(0, 3)];
                chairs.Add(new Chair(i, color, name));
            }

            return chairs;
        }

        static void ArrangeChairs(List<Chair> chairs)
        {
            chairs.Sort((a, b) => a.Number.CompareTo(b.Number));


            chairs.Sort((a, b) =>
            {
                if (a.Color == "Red" && b.Color == "Green")
                    return 1;
                else if (a.Color == "Green" && b.Color == "Red")
                    return -1;
                else
                    return 0;
            });

            chairs.Sort((a, b) =>
            {
                if (a.PersonName == "Maxim" && b.PersonName == "Ivan")
                    return 1;
            }
            }
    }
}
