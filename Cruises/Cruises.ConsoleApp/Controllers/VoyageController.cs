namespace Cruises.ConsoleApp.Controllers
{
    using Cruises.Service;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class VoyageController
    {
        private VoyageService voyageService;
        public VoyageController()
        {
            voyageService = new VoyageService();
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
                            GetExactVoyageInfo();
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

        public void GetExactVoyageInfo()
        {
            try
            {
                Console.Write($"> Enter project's id: ");
                int id = int.Parse(Console.ReadLine());
                string result = voyageService.GetVoyageInfo(id);
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
            sb.AppendLine($"Projects menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Get exact voyage info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
