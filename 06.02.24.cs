using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Figure
    {
        public void CalculateArea()
        {
            Console.WriteLine("Площа: 0");
        }
    }

    public class Square : Figure
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Площа квадрата: " + sideLength * sideLength);
        }
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Площа кола: " + Math.PI * radius * radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Circle circle = new Circle(3);

            square.CalculateArea();
            circle.CalculateArea();
        }
    }
}
