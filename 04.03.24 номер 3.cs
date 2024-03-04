using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic dA = a;
            dynamic dB = b;
            return dA + dB;
        }

        public T Subtract(T a, T b)
        {
            dynamic dA = a;
            dynamic dB = b;
            return dA - dB;
        }

        public T Multiply(T a, T b)
        {
            dynamic dA = a;
            dynamic dB = b;
            return dA * dB;
        }

        public T Divide(T a, T b)
        {
            dynamic dA = a;
            dynamic dB = b;
            if (dB == 0)
            {
                throw new ArgumentException("Деление на ноль.");
            }
            return dA / dB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Сложение: " + intCalculator.Add(5, 3));
            Console.WriteLine("Вычитание: " + intCalculator.Subtract(5, 3));
            Console.WriteLine("Умножение: " + intCalculator.Multiply(5, 3));
            try
            {
                Console.WriteLine("Деление: " + intCalculator.Divide(5, 0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("Сложение: " + doubleCalculator.Add(5.5, 3.2));
            Console.WriteLine("Вычитание: " + doubleCalculator.Subtract(5.5, 3.2));
            Console.WriteLine("Умножение: " + doubleCalculator.Multiply(5.5, 3.2));
            try
            {
                Console.WriteLine("Деление: " + doubleCalculator.Divide(5.5, 0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
