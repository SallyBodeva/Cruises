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
        static void Main()
        {
            //CreateCities();
            //CreatеShipTypes();
            //CreatеVoyages();
            CreatеPassengers();
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
        public static void CreatеVoyages()
        {

            List<string> imaginaryHarbors = new List<string>()
                    {
                        "Starlight Bay Harbor", "Crystal Cove Port","Azure Haven Harbor",
                        "Whispering Winds Marina","Enchanted Lagoon Port","Serenity Shores Harbor",
                        "Moonlit Mist Wharf","Twilight Harbor Bay", "Dreamweaver Quay","Radiant Reef Port",
                        "Celestial Crescent Harbor","Mystique Isle Marina","Elysian Echo Cove",
                        "Harmony Harbor Port","Nebula Mirage Wharf","Ethereal Echoes Bay",
                        "Siren's Song Cove","Astral Haven Harbor","Mirage Moonrise Port"
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
            Console.WriteLine(pS.AddPassenger("Jane", "Smith", "0000000001", 24, false,false));
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
    }
}