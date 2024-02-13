using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public static class Algorithms
    {
        public static List<object> OpenArr(List<object> inputArr)
        {
            List<object> result = new List<object>();

            for (int i = 0; i < inputArr.Count; i++)
            {
                if (inputArr[i] is List<object>)
                {
                    result.AddRange(OpenArr((List<object>)inputArr[i]));
                }
                else
                {
                    result.Add(inputArr[i]);
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<object> myArr = new List<object> {6, 44, 23,
            new List<object> {53,
                new List<object> {22, 32, 67},
                12,
                new List<object> {
                    4, 6, 2
                }
            }
        };

            List<object> flattenedArr = Algorithms.OpenArr(myArr);

            Console.WriteLine("Выровненный массив: ");
            for (int i = 0; i < flattenedArr.Count; i++)
            {
                Console.Write(flattenedArr[i] + " ");
            }
        }
    }
}
