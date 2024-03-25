using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleApp39
{
    public class Client
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string UniqueID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Додати нового клієнта");
                Console.WriteLine("2. Редагувати дані клієнта");
                Console.WriteLine("3. Показати всіх клієнтів");
                Console.WriteLine("4. Вийти");
                Console.Write("Виберіть опцію: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddClient();
                        break;
                    case "2":
                        EditClient();
                        break;
                    case "3":
                        ShowAllClients();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void AddClient()
        {
            Console.Write("Введіть ПІП клієнта: ");
            string fullName = Console.ReadLine();

            Console.Write("Введіть вік клієнта: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введіть номер телефону клієнта: ");
            string phoneNumber = Console.ReadLine();

            string uniqueID = Guid.NewGuid().ToString();

            Client client = new Client()
            {
                FullName = fullName,
                Age = age,
                PhoneNumber = phoneNumber,
                UniqueID = uniqueID
            };

            SerializeClient(client);
        }

        static void SerializeClient(Client client)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Client));
            using (TextWriter writer = new StreamWriter("clients.xml", true))
            {
                serializer.Serialize(writer, client);
            }
        }

        static void EditClient()
        {
            Console.WriteLine("Функція редагування ще не реалізована.");
        }

        static void ShowAllClients()
        {
            if (!File.Exists("clients.xml"))
            {
                Console.WriteLine("База даних клієнтів порожня.");
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Client));
            using (XmlReader reader = XmlReader.Create("clients.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Client")
                    {
                        Client client = (Client)serializer.Deserialize(reader);
                        Console.WriteLine($"ПІП: {client.FullName}, Вік: {client.Age}, Номер телефону: {client.PhoneNumber}, ID: {client.UniqueID}");
                    }
                }
            }
        }
    }

}
