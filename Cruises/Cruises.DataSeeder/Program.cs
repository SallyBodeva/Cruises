using Cruises.Models;
using Cruises.Service;
using System;
using System.Collections.Generic;

namespace Cruises.DataSeeder
{
    public class Program
    {
        private static AdditionalService aS = new AdditionalService();
        private static VoyageService vS = new VoyageService();
        private static HarbourService hS = new HarbourService();
        private static PassengerService pS = new PassengerService();
        private static CrewService cS = new CrewService();
        private static ShipService sS = new ShipService();
        static void Main()
        {
            //CreateCities();
            //CreatеShipTypes();
            //CreatеHarbours();
            //CreatеPassengers();
            //CreatеCrewMembers();
            //CreatеShip();
            //CreatеVoyages();
            //CreateImages();

        }
        public static void CreateCities()
        {
            List<string> cities = new List<string>()
        {
            "Barcelona","Marseille","Athens","Istanbul","Alexandria","Naples","Valencia", "Split","Malaga","Genoa"
        };

            List<string> countries = new List<string>()
        {
            "Spain","France","Greece","Turkey","Egypt","Italy","Spain","Croatia","Spain","Italy"
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
            "Basic Ship", "Passenger Ferry","Catamaran","Tall ship","Yacht"
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
                        "Moonlit Mist Wharf","Twilight Harbour Bay", "Dreamweaver Quay","Radiant Reef Port"
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
                      "Azure Dreamer"
                    };
            List<string> shipTypes = sS.GetShipTypeName();
            Random random = new Random();
            List<string> models = new List<string>() { "B.001", "B.002", "B.003", "B.004", "B.005", "B.010" };

            for (int i = 0; i < imaginaryShipName.Count; i++)
            {
                int model = random.Next(0, models.Count);
                int capacity = random.Next(50, 200);
                int isFulll = random.Next(0, 1);
                bool boolValue = (isFulll != 0);
                Console.WriteLine(sS.CreateShip(imaginaryShipName[i], models[model], capacity, shipTypes[i], boolValue));
            }
        }
        public static void CreatеVoyages()
        {
            for (int i = 0; i < 15; i++)
            {
                Random random = new Random();
                List<string> fromHarbours = aS.GetFromHarbours();
                int fH = random.Next(0, fromHarbours.Count);
                string fHName = hS.GetHarbourNameByIndex(fH);

                int tH = random.Next(0, fromHarbours.Count - 1);
                List<string> toHarbours = aS.GetToHarbours(tH);
                string tHName = hS.GetHarbourNameByIndex(tH);

                List<string> shipsName = sS.GetShipNames();
                int ship = random.Next(0, shipsName.Count);

                List<int> durations = new List<int>() { 1, 2, 3, 4 };
                int dInxed = random.Next(0, durations.Count);

                List<decimal> price = new List<decimal>() { 25.00m, 18.99m, 99.99m, 10.00m, 29.99m };
                int pInxed = random.Next(0, price.Count);
                if (fHName != tHName)
                {
                    Console.WriteLine(vS.CreateVoyage(fHName, tHName, durations[dInxed], shipsName[ship], price[pInxed]));
                }
                else
                {
                    Console.WriteLine("Cannot assign a travel from one Harbour to the same Harbour");
                }
            }
        }
        public static void CreateImages()
        {
            List<string> urls = new List<string>() {
           "https://www.kongsberg.com/contentassets/e6051e3c95bb463fbbf7a1dda2c95571/nvc-376-wp-gold-kongsberg-10-cam1_10-color-1.jpg",
           "https://www.bairdmaritime.com/wp-content/uploads/IC19082-8-0-031.jpg",
           "https://www.simpsonmarine.com/wp-content/uploads/2022/10/navigation-helico-ncz9473-a3-1-scaled.jpg",
           "https://southernboating.com/wp-content/uploads/2018/01/Ted-Neighbors-1_RT.jpg",
           "https://cdn.boatinternational.com/convert/files/2022/07/76393b30-0096-11ed-aed3-f71d7c568098-AHPO-hero-Photography-guillaume-plisson.jpg/r%5Bwidth%5D=1920/76393b30-0096-11ed-aed3-f71d7c568098-AHPO-hero-Photography-guillaume-plisson.jpg"
            };
            List<int> shipsId = sS.GetShipsId();
            for (int i = 0; i < urls.Count; i++)
            {
                Console.WriteLine(sS.AddImageToShip(shipsId[i], urls[i]));
            }
        }
    }
}