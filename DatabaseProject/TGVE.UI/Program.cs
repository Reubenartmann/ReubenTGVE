using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TGVE.UI
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mainMenu = "1. View Tours" + "\n" + "2. View Clients" + "\n" + "3. Create Client";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Input selection");
                Console.WriteLine(mainMenu);
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Task.Run(ViewTours).Wait();
                        break;
                    case "2":
                        Console.Clear();
                        Task.Run(ViewClients).Wait();
                        break;
                    case "3":
                        Console.Clear();
                        Task.Run(createClient).Wait();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(mainMenu);
                        break;
                }
            }
        }

        public static async Task ViewClients()
        {
            var mainMenu = "1. View Tours" + "\n" + "2. View Clients" + "\n" + "3. Create Client";
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Retrieving Client Information...");
                var response = await client.GetAsync("http://localhost:52351/api/clients");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Client>>(stringResponse);
                for (int i = 0; i < responseObject.Count; i++)
                {
                    Console.WriteLine(responseObject[i].ToString());
                }
                Console.WriteLine("Return to main menu: Y/N");
                string input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "Y":
                        Console.Clear();
                        Console.WriteLine(mainMenu);
                        break;
                    case "N":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(mainMenu);
                        break;
                }
            }
            Console.Clear();
        }

        public static async Task createClient() //INCOMPLETE
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Input ID: ");
                var nID = Console.ReadLine();
                Console.WriteLine("Input first name: ");
                var nfirstName = Console.ReadLine();
                Console.WriteLine("Input last name: ");
                var nlastName = Console.ReadLine();
                Console.WriteLine("Input phone number: ");
                var nphoneNumber = Console.ReadLine();
                Console.WriteLine("Input address : ");
                var naddress = Console.ReadLine();
                Console.WriteLine("Input date of birth DD/MM/YYYY: ");
                var nDOB = Console.ReadLine();
                Console.WriteLine("Input email address: ");
                var nemail = Console.ReadLine();

                var newClient = new Client()
                {
                    ID = nID,
                    firstName = nfirstName,
                    lastName = nlastName,
                    phoneNumber = nphoneNumber,
                    address = naddress,
                    DOB = nDOB,
                    email = nemail
                };


            }
            Console.WriteLine("New client has been added.");
            Console.Read();
            Console.Clear();
        }

        public static async Task ViewTours()
        {
            var mainMenu = "1. View Tours" + "\n" + "2. View Clients" + "\n" + "3. Create Client";

            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Retrieving Tour Information...");
                var response = await client.GetAsync("http://localhost:52351/api/tours");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<Tour>>(stringResponse);
                for (int i = 0; i < responseObject.Count; i++)
                {
                    Console.WriteLine(responseObject[i].ToString());
                }
                Console.WriteLine("Return to main menu: Y/N");
                string input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "Y":
                        Console.Clear();
                        Console.WriteLine(mainMenu);
                        break;
                    case "N":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(mainMenu);
                        break;
                }
            }
            Console.Clear();
        }
    }
}
