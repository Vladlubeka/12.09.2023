using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UserManagementSystem
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
        public string Status { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
    }

    class Program
    {
        private const string filename = "users.xml";

        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            if (File.Exists(filename))
            {
                users = DeserializeUsers(filename);
            }

            while (true)
            {
                Console.WriteLine("1. Додати користувача");
                Console.WriteLine("2. Редагувати користувача");
                Console.WriteLine("3. Видалити користувача");
                Console.WriteLine("4. Вивести інформацію по усім користувачам");
                Console.WriteLine("5. Вийти");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        users.Add(CreateUser());
                        break;
                    case 2:
                        EditUser(users);
                        break;
                    case 3:
                        DeleteUser(users);
                        break;
                    case 4:
                        DisplayUsers(users);
                        break;
                    case 5:
                        SerializeUsers(users, filename);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір");
                        break;
                }
            }
        }

        static User CreateUser()
        {
            User user = new User();

            Console.Write("Ім'я: ");
            user.Name = Console.ReadLine();

            Console.Write("Пароль: ");
            user.Password = Console.ReadLine();

            Console.Write("Пошта: ");
            user.Email = Console.ReadLine();

            Console.Write("Вік: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.Write("Баланс: ");
            user.Balance = decimal.Parse(Console.ReadLine());

            Console.Write("Статус: ");
            user.Status = Console.ReadLine();

            Console.Write("Дата народження (yyyy-MM-dd): ");
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Країна: ");
            user.Country = Console.ReadLine();

            return user;
        }

        static void EditUser(List<User> users)
        {
            Console.Write("Введіть ім'я користувача, якого потрібно редагувати: ");
            string name = Console.ReadLine();

            User user = users.Find(u => u.Name == name);
            if (user == null)
            {
                Console.WriteLine("Користувача з таким ім'ям не знайдено.");
                return;
            }

            Console.WriteLine("Введіть нові дані:");

            Console.Write("Пароль: ");
            user.Password = Console.ReadLine();

            Console.Write("Пошта: ");
            user.Email = Console.ReadLine();

            Console.Write("Вік: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.Write("Баланс: ");
            user.Balance = decimal.Parse(Console.ReadLine());

            Console.Write("Статус: ");
            user.Status = Console.ReadLine();

            Console.Write("Дата народження (yyyy-MM-dd): ");
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Країна: ");
            user.Country = Console.ReadLine();
        }

        static void DeleteUser(List<User> users)
        {
            Console.Write("Введіть ім'я користувача, якого потрібно видалити: ");
            string name = Console.ReadLine();

            User user = users.Find(u => u.Name == name);
            if (user == null)
            {
                Console.WriteLine("Користувача з таким ім'ям не знайдено.");
                return;
            }

            users.Remove(user);
            Console.WriteLine("Користувача видалено.");
        }

        static void DisplayUsers(List<User> users)
        {
            Console.WriteLine("Ім'я\tПароль\tПошта\tВік\tБаланс\tСтатус\tДата народження\tКраїна");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}\t{user.Password}\t{user.Email}\t{user.Age}\t{user.Balance}\t{user.Status}\t{user.DateOfBirth.ToShortDateString()}\t{user.Country}");
            }
        }

        static void SerializeUsers(List<User> users, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, users);
            }
        }

        static List<User> DeserializeUsers(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextReader reader = new StreamReader(filename))
            {
                return (List<User>)serializer.Deserialize(reader);
            }
        }
    }
}
