using Cruises.Service;
using System;
using System.Collections.Generic;

namespace Cruises.DataSeeder
{
    public class Program
    {
        private static AdditionalService aS = new AdditionalService();
        static void Main()
        {
            CreateCities();
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
    }
}
