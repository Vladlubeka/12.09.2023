using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> tasks = new List<object>();

            Task mainTask = new Task("Виконати проект", "Розробити систему обліку завдань", DateTime.Now.AddDays(7));
            tasks.Add(mainTask);

            SubTask subTask1 = new SubTask("Підготовка звіту", "Підготувати звіт по розробленій системі", DateTime.Now.AddDays(5));
            mainTask.AddSubTask(subTask1);

            SubTask subTask2 = new SubTask("Тестування", "Протестувати різні сценарії в системі", DateTime.Now.AddDays(3));
            mainTask.AddSubTask(subTask2);
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] is Task)
                {
                    Task currentTask = (Task)tasks[i];
                    Console.WriteLine("Завдання: " + currentTask.Title + ", Статус: " + currentTask.Status);

                    for (int j = 0; j < currentTask.SubTasks.Count; j++)
                    {
                        SubTask currentSubTask = currentTask.SubTasks[j];
                        Console.WriteLine("    Підзавдання: " + currentSubTask.Title + ", Статус: " + currentSubTask.Status);
                    }
                }
            }
        }
    }
}

