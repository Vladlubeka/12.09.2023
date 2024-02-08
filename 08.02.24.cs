using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    using System;

    public static class ArrayOperations
    {
        public static int MinIn2DArray(int[,] array)
        {
            int minSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                minSum += min;
            }
            return minSum;
        }

        public static int MaxIn2DArray(int[,] array)
        {
            int maxSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                maxSum += max;
            }
            return maxSum;
        }

        public static int DifferenceIn2DArray(int[,] array)
        {
            return MaxIn2DArray(array) - MinIn2DArray(array);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {
                {5,3,2,4,1},
                {8,10,6,9,7},
                {13,15,11,14,15},
                {44,55,12,10,3}
        };

            Console.WriteLine("Сумма минимальных значений: " + ArrayOperations.MinIn2DArray(numbers));
            Console.WriteLine("Сумма максимальных значений: " + ArrayOperations.MaxIn2DArray(numbers));
            Console.WriteLine("Разница между максимальным и минимальным значениями: " + ArrayOperations.DifferenceIn2DArray(numbers));
        }
    }

}
