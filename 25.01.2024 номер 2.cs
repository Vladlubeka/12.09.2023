using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Student
    {
        public string FullName { get; set; }
        public int StudentId { get; set; }
        public int Age { get; set; }

        public Student(string fullName, int studentId, int age)
        {
            FullName = fullName;
            StudentId = studentId;
            Age = age;
        }
    }

    class StudentGroup
    {
        public int GroupNumber { get; set; }
        public Student[] Students { get; set; }

        public StudentGroup(int groupNumber)
        {
            GroupNumber = groupNumber;
            Students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
