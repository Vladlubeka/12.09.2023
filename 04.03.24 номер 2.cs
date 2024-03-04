using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Перед обменом: a = " + a + ", b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("После обмена: a = " + a + ", b = " + b);

            double x = 3.5;
            double y = 7.8;
            Console.WriteLine("Перед обменом: x = " + x + ", y = " + y);
            Swap(ref x, ref y);
            Console.WriteLine("После обмена: x = " + x + ", y = " + y);
        }

        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
