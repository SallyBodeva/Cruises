using Cruises.Service;
using System;
using System.Collections.Generic;

namespace Cruises.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            AdditionalService aS = new AdditionalService();
            List<string> cities = aS.GetCitiesNames();
            List<string> countries = aS.GetCitiesNames();
            Console.WriteLine(string.Join(" ",cities));
        }
    }
}
