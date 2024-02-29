using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AverageGrade { get; set; }
    }

    class StudentList
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void ProcessStudents(StudentActionDelegate action)
        {
            foreach (var student in students)
            {
                action(student);
            }
        }
    }

    delegate void StudentActionDelegate(Student student);

    class Program
    {
        static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"Студент: {student.FirstName} {student.LastName}, Средняя оценка: {student.AverageGrade}");
        }

        static void IncreaseAverageGrade(Student student)
        {
            student.AverageGrade += 0.5;
        }

        static void Main(string[] args)
        {
            StudentList studentList = new StudentList();

            studentList.AddStudent(new Student { FirstName = "John", LastName = "Doe", AverageGrade = 4.0 });
            studentList.AddStudent(new Student { FirstName = "Alice", LastName = "Smith", AverageGrade = 3.5 });
            studentList.AddStudent(new Student { FirstName = "Bob", LastName = "Johnson", AverageGrade = 3.7 });

            StudentActionDelegate printDelegate = new StudentActionDelegate(PrintStudentInfo);
            StudentActionDelegate increaseGradeDelegate = new StudentActionDelegate(IncreaseAverageGrade);

            Console.WriteLine("Исходная информация об ученике: ");
            studentList.ProcessStudents(printDelegate);

            Console.WriteLine("\nПосле повышения средних оценок:");
            studentList.ProcessStudents(increaseGradeDelegate);
            studentList.ProcessStudents(printDelegate);

            Console.ReadLine();
        }
    }
}
