﻿using Cruises.Service;
using System;

namespace Cruises.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            AdditionalService aS = new AdditionalService();
            Console.WriteLine(aS.CreateCity("Burgas","Bulgaria"));
        }
    }
}
