using Cruises.Service;
using System;
using System.Collections.Generic;

namespace Cruises.ConsoleApp
{
    internal class Program
    {
        private static AdditionalService aS = new AdditionalService();
        static void Main()
        {
            Console.WriteLine(aS.CreateVoyage("Enchanted Lagoon Port", "Enchanted Lagoon Port", 2, "Ocean Voyager",12.00m));
        }
        public static void CreatеVoyages()
        {
            for (int i = 0; i < 15; i++)
            {
                Random random = new Random();
                List<string> fromHarbours = aS.GetFromHarbours();
                int fH = random.Next(0, fromHarbours.Count);
                string fHName = aS.GetHarbourNameByIndex(fH);

                int tH = random.Next(0, fromHarbours.Count - 1);
                List<string> toHarbours = aS.GetToHarbours(tH);
                string tHName = aS.GetHarbourNameByIndex(tH);

                List<string> shipsName = aS.GetShipNames();
                int ship = random.Next(0, shipsName.Count);

                List<int> durations = new List<int>() { 1, 2, 3, 4 };
                int dInxed = random.Next(0, durations.Count);

                List<decimal> price = new List<decimal>() { 25.00m, 18.99m, 99.99m, 10.00m, 29.99m };
                int pInxed = random.Next(0, price.Count);
                if (tH != fH)
                {
                    Console.WriteLine(aS.CreateVoyage(fHName, tHName, durations[dInxed], shipsName[ship], price[pInxed]));
                }
                else
                {
                    Console.WriteLine("Cannot assign a travel from one Harbour to the same Harbour");
                }
            }
        }
    }
}
