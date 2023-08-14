using Cruises.Service;
using System;

namespace Cruises.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            HarbourService hs = new HarbourService();
            Console.WriteLine(hs.GetAllHarboursInfo());
        }
    }
}
