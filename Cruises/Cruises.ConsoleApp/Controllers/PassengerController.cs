namespace Cruises.ConsoleApp.Controllers
{
    using Cruises.Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class PassengerController
    {
        private PassengerService passengerService;
        public PassengerController()
        {
            passengerService = new PassengerService();
            Run();
        }
        private void Run()
        {
            while (true)
            {
                try
                {

                    Console.Clear();
                    Commands();
                    Console.Write("> Enter command:");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "0":
                            return;
                        case "1":
                            PrintPassengersInfo();
                            break;
                        case "2":
                            AddNewPassenger();
                            break;
                        case "3":
                            GetExactPassengerInfo();
                            break;
                        default:
                            Console.WriteLine("Invalid command!");
                            WaitPressKey();

                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    WaitPressKey();
                }
            }
        }
        public void PrintPassengersInfo()
        {
            int currentPage = 1;
            int pageCount = passengerService.GetPassengersPagesCount();
            while (true)
            {
                Console.Clear();
                try
                {
                    string result = passengerService.GetAllPassengersInfo(currentPage);
                    Console.WriteLine(result);
                    Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                    Console.Write("Enter command: ");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "0":
                            return;
                        case "1":
                            if (currentPage > 1) { currentPage--; }
                            break;
                        case "2":
                            if (currentPage < pageCount) { currentPage++; }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
        public void AddNewPassenger()
        {
            Console.Write($"> Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write($"> Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write($"> Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"> Enter phone number(it has to be 10 digits only): ");
            string number = Console.ReadLine();
            if (number.Count() != 10)
            {
                Console.WriteLine("Invalid phone number!");
                WaitPressKey();
                return;
            }
            Console.Write($"> Enter info if the passenger is student (Enter 1 for yes and 0 for no): ");
            string student = Console.ReadLine();
            Console.Write($"> Enter info if the passenger is retiree (Enter 1 for yes and 0 for no): ");
            string retiree = Console.ReadLine();
            bool isStudent;
            if (student == "1") { isStudent = true; }
            else { isStudent = false; }
            bool isRetiree;
            if (retiree == "1") { isRetiree = true; }
            else { isRetiree = false; }
            string result = passengerService.AddPassenger(firstName, lastName, number, age, isStudent, isRetiree);
            Console.WriteLine(result);
            WaitPressKey();
        }
        public void GetExactPassengerInfo()
        {
            try
            {
                Console.Write($"> Enter passenger's id: ");
                int id = int.Parse(Console.ReadLine());
                string result = passengerService.GetPassengerInfoById(id);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            WaitPressKey();
        }
        private static void WaitPressKey()
        {
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }
        public void Commands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Clients menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Passengers list");
            sb.AppendLine($"\t2: Add new passenger");
            sb.AppendLine($"\t3: Get exact passenger info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
