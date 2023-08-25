namespace Cruises.ConsoleApp.Controllers
{
    using Cruises.Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class CrewController
    {
        private CrewService crewService;
        public CrewController()
        {
            crewService = new CrewService();
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
                            PrintCrewInfo();
                            break;
                        case "2":
                            HireNewCrewMember();
                            break;
                        case "3":
                            DeleteCrewMember();
                            break;
                        case "4":
                            UpdateCrewRating();
                            break;
                        case "5":
                            GetExactCrewMeberInfo();
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
        public void PrintCrewInfo()
        {
            int currentPage = 1;
            int pageCount = crewService.GetCrewPagesCount();
            while (true)
            {
                try
                {
                    Console.Clear();
                    string result = crewService.GetAllCrewMembersInfo(currentPage);
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
        public void GetExactCrewMeberInfo()
        {
            Console.Write($"> Enter crew member's id: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                string result = crewService.GetCrewMemebrInfo(id);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            WaitPressKey();
        }
        public void HireNewCrewMember()
        {
            try
            {
                Console.Write($"> Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write($"> Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write($"> Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"> The rating of the new crew members is always: 5.00");
                Console.Write($"> Enter position: ");
                string position = Console.ReadLine();

                string result = crewService.AddCrewMember(firstName, lastName, age, 5.00, position);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            WaitPressKey();
        }
        public void DeleteCrewMember()
        {
            try
            {
                Console.Write($"> Enter employee's id: ");
                int id = int.Parse(Console.ReadLine());
                string result = crewService.DeleteCrewMemberById(id);
                Console.WriteLine(result);
                WaitPressKey();
            }
            catch (Exception)
            {
                Console.WriteLine("This crew member cannot be discharge, his voyages are still remainig...");
                WaitPressKey();
            }
        }
        public void UpdateCrewRating()
        {
            Console.Write($"> Enter employee's id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"> Enter new rating: ");
            double r = double.Parse(Console.ReadLine());
            string result = crewService.UpdateCrewMemberRatingById(id, r);
            Console.WriteLine(result);
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
            sb.AppendLine($"Employees menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Crew members list");
            sb.AppendLine($"\t2: Hire new crew member");
            sb.AppendLine($"\t3: Discharge crew member");
            sb.AppendLine($"\t4: Update crew member rating");
            sb.AppendLine($"\t5: Get exact crew member info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
