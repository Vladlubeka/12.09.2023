using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ServiceCenter> serviceCenters = new List<ServiceCenter>
        {
            new ServiceCenter(1),
            new ServiceCenter(2),
            new FastServiceCenter(3), // Быстрый СТО
            new ServiceCenter(4)
        };

            for (int i = 0; i < serviceCenters.Count; i++)
            {
                ServiceCenter currentServiceCenter = serviceCenters[i];
                bool isAvailable = currentServiceCenter.IsAvailable();

                Console.WriteLine("СТО " + currentServiceCenter.Number + " свободен: " + isAvailable);
            }

            Client client1 = new Client("John Doe", "Смена масла", 5);
            Client client2 = new Client("Alice Smith", "Починка бампера", 7);
            Client client3 = new Client("Bob Johnson", "Покраска детали", 3);

            serviceCenters[0].AddClient(client1);
            serviceCenters[1].AddClient(client2);
            serviceCenters[3].AddClient(client3);

            Console.WriteLine("\nСТО после добавления клиентов:");

            for (int i = 0; i < serviceCenters.Count; i++)
            {
                ServiceCenter currentServiceCenter = serviceCenters[i];
                bool isAvailable = currentServiceCenter.IsAvailable();

                Console.WriteLine("СТО " + currentServiceCenter.Number + " свободен: " + isAvailable);
            }
        }
    }

    class ServiceCenter
    {
        public int Number { get; }
        private List<Client> clients;

        public ServiceCenter(int number)
        {
            Number = number;
            clients = new List<Client>();
        }

        public bool IsAvailable()
        {
            return clients.Count == 0;
        }

    }
}
