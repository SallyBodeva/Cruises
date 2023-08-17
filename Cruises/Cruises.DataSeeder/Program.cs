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
        static void Main()
        {
            //CreateCities();
            //CreatеShipTypes();
            CreatеVoyages();
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
    }
}