using Cruises.Models;
using Cruises.Service;
using System;
using System.Collections.Generic;

namespace Cruises.DataSeeder
{
    public class Program
    {
        private static AdditionalService aS = new AdditionalService();
        private static HarbourService hS = new HarbourService();
        private static PassengerService pS = new PassengerService();
        private static CrewService cS = new CrewService();
        static void Main()
        {
            //CreateCities();
            //CreatеShipTypes();
            //CreatеHarbours();
            //CreatеPassengers();
            //CreatеCrewMembers();
            //CreatеShip();
           // CreatеVoyages();
        }
        public static void CreateCities()
        {
            List<string> cities = new List<string>()
        {
            "Sydney","Hong Kong","New York City","Mumbai","Rotterdam","Tokyo","San Francisco","Barcelona","Cape Town","Vancouver",
            "Dubai","Rio de Janeiro","Singapore City","Istanbul","Marseille","Copenhagen","Buenos Aires","Hamburg","Alexandria","Oslo"
        };

            List<string> countries = new List<string>()
        {
            "Australia","China","USA","India","Netherlands","Japan","USA","Spain","South Africa","Canada","United Arab Emirates","Brazil","Singapore","Turkey",
            "France","Denmark","Argentina","Germany","Egypt","Norway"
        };

            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(aS.CreateCity(cities[i], countries[i]));
            }
        }
        public static void CreatеShipTypes()
        {
            List<string> cruiseShipTypes = new List<string>()
        {
            "Cruise Ship","Yacht","Sailing Ship", "Passenger Ferry","Catamaran", "Tall Ship","Ocean Liner","Barge"
        };

            for (int i = 0; i < cruiseShipTypes.Count; i++)
            {
                Console.WriteLine(aS.CreateShipTypes(cruiseShipTypes[i]));
            }
        }
        public static void CreatеHarbours()
        {

            List<string> imaginaryHarbors = new List<string>()
                    {
                        "Starlight Bay Harbour", "Crystal Cove Port","Azure Haven Harbour",
                        "Whispering Winds Marina","Enchanted Lagoon Port","Serenity Shores Harbour",
                        "Moonlit Mist Wharf","Twilight Harbour Bay", "Dreamweaver Quay","Radiant Reef Port",
                        "Celestial Crescent Harbour","Mystique Isle Marina","Elysian Echo Cove",
                        "Harmony Harbour Port","Nebula Mirage Wharf","Ethereal Echoes Bay",
                        "Siren's Song Cove","Astral Haven Harbour","Mirage Moonrise Port"
                    };
            List<string> cities = aS.GetCitiesNames();
            List<string> countries = aS.GetCountriesNames();

            for (int i = 0; i < imaginaryHarbors.Count; i++)
            {
                Console.WriteLine(hS.CreateHarbour(imaginaryHarbors[i], cities[i], countries[i]));
            }
        }
        public static void CreatеPassengers()
        {
            Console.WriteLine(pS.AddPassenger("Jane", "Smith", "0000000001", 24, false, false));
            Console.WriteLine(pS.AddPassenger("John", "Doe", "1111111111", 13, true, false));
            Console.WriteLine(pS.AddPassenger("Alice", "Johnson", "2222222222", 21, true, false));
            Console.WriteLine(pS.AddPassenger("Michael", "Williams", "3333333333", 45, false, false));
            Console.WriteLine(pS.AddPassenger("Emily", "Brown", "4444444444", 22, true, false));
            Console.WriteLine(pS.AddPassenger("Daniel", "Miller", "5555555555", 62, false, true));
            Console.WriteLine(pS.AddPassenger("Olivia", "Davis", "6666666666", 19, true, false));
            Console.WriteLine(pS.AddPassenger("William", "Martinez", "7777777777", 64, false, true));
            Console.WriteLine(pS.AddPassenger("Sophia", "Garcia", "8888888888", 21, true, false));
            Console.WriteLine(pS.AddPassenger("James", "Jones", "9999999999", 72, false, true));
            Console.WriteLine(pS.AddPassenger("Ava", "Rodriguez", "1234567890", 20, true, false));
            Console.WriteLine(pS.AddPassenger("Robert", "Lopez", "2345678901", 58, false, true));
            Console.WriteLine(pS.AddPassenger("Mia", "Hernandez", "3456789012", 25, true, false));
            Console.WriteLine(pS.AddPassenger("David", "Smith", "4567890123", 40, false, false));
            Console.WriteLine(pS.AddPassenger("Isabella", "Johnson", "5678901234", 16, true, false));
            Console.WriteLine(pS.AddPassenger("Joseph", "Williams", "6789012345", 68, false, true));

        }
        public static void CreatеCrewMembers()
        {
            Console.WriteLine(cS.AddCrewMember("Milan", "Smith", 26, 7.2, "Boatswain"));
            Console.WriteLine(cS.AddCrewMember("Emma", "Johnson", 32, 8.5, "Chief Officer"));
            Console.WriteLine(cS.AddCrewMember("Liam", "Williams", 40, 9.0, "Captain"));
            Console.WriteLine(cS.AddCrewMember("Olivia", "Brown", 28, 6.8, "Third Officer"));
            Console.WriteLine(cS.AddCrewMember("Noah", "Jones", 23, 7.7, "Ordinary Seaman"));
            Console.WriteLine(cS.AddCrewMember("Ava", "Davis", 35, 8.2, "Chief Engineer"));
            Console.WriteLine(cS.AddCrewMember("Isabella", "Miller", 29, 6.5, "Second Engineer"));
            Console.WriteLine(cS.AddCrewMember("Sophia", "Wilson", 45, 9.8, "Chief Steward"));
            Console.WriteLine(cS.AddCrewMember("Ethan", "Moore", 31, 7.9, "Cook"));
            Console.WriteLine(cS.AddCrewMember("Mia", "Taylor", 27, 7.0, "Medical Officer"));
            Console.WriteLine(cS.AddCrewMember("James", "Anderson", 22, 6.2, "Radio Operator"));
            Console.WriteLine(cS.AddCrewMember("Alexander", "Martinez", 33, 8.7, "Second Officer"));
            Console.WriteLine(cS.AddCrewMember("Charlotte", "Garcia", 39, 8.0, "Electrician"));
            Console.WriteLine(cS.AddCrewMember("Daniel", "Lopez", 30, 7.4, "Pumpman"));
            Console.WriteLine(cS.AddCrewMember("Amelia", "Hernandez", 36, 8.9, "Able Seaman"));
        }
        public static void CreatеShip()
        {

            List<string> imaginaryShipName = new List<string>()
                    { "Ocean Voyager","Stellar Mariner","Sunset Serenade","Majestic Horizon",
                      "Azure Dreamer","Silver Crest","Golden Odyssey","Emerald Seahawk","Crystal Mirage",
                      "Harbor Majesty","Sapphire Starlight","Whispering Wind","Crimson Tide",
                      "Radiant Pearl","Aurora Borealis","Mystic Galleon","Enchanted Voyager",
                      "Celestial Odyssey","Eternal Skylark","Coral Destiny"
                    };
            List<string> shipTypes = aS.GetShipTypeName();
            Random random = new Random();
            List<string> models = new List<string>() { "B.001", "B.002", "B.003", "B.004", "B.005", "B.010" };

            for (int i = 0; i < imaginaryShipName.Count; i++)
            {
                int model = random.Next(0, models.Count);
                int capacity = random.Next(50, 200);
                int shitType = random.Next(0, 8);
                int isFulll = random.Next(0, 1);
                bool boolValue = (isFulll != 0);
                Console.WriteLine(aS.CreateShip(imaginaryShipName[i], models[model], capacity, shipTypes[shitType], boolValue));
            }
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
                if (fHName!=tHName)
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