using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
     {
            new Student { FirstName = "Iван", LastName = "Iванов", Age = 20 },
            new Student { FirstName = "Марiя", LastName = "Петренко", Age = 19 },
            new Student { FirstName = "Олексiй", LastName = "Сидоренко", Age = 22 },
            new Student { FirstName = "Наталiя", LastName = "Грищенко", Age = 18 },
     };

            PrintStudentsOlderThan18(students);
        }

        static void PrintStudentsOlderThan18(Student[] students)
        {
            Console.WriteLine("Студенти старшi 18 рокiв:");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Age > 18)
                {
                    Console.WriteLine("Iм'я: " + students[i].FirstName + ", Прiзвище: " + students[i].LastName + ", Вiк: " + students[i].Age + " рокiв");
                }
            }
        }
    }
}
