namespace Cruises.ConsoleApp
{
    using Cruises.ConsoleApp.Controllers;
    using Cruises.Service;
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Commands();
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        new CrewController();
                        break;
                    case "2":
                        new PassengerController();
                        break;
                    case "3":
                        new VoyageController();
                        break;
                    case "4":
                        new ShipController();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        public static void Commands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Enchanted Escala menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Crew members");
            sb.AppendLine($"\t2: Passengers");
            sb.AppendLine($"\t3: Voyages");
            sb.AppendLine($"\t4: Ships");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
