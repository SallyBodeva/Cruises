namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using Cruises.Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class HarbourService
    {
        private AppDbContext context;

        public string CreateHarbour(string name, string city,string country)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine("Inavlid name of the new Harbour");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                message.AppendLine("Inavlid id of the city");
                isValid = false;
            }
            City c = null;
            using (context = new AppDbContext())
            {
                c = this.context.Cities.FirstOrDefault(x => x.Name == name && x.Country==country);
                if (c==null)
                {
                    c = new City() { Name=city,Country=country };
                }
                if (isValid)
                {
                    Harbour h = new Harbour()
                    {
                        Name = name,
                        City = c
                    };
                    context.Harbours.Add(h);
                    context.SaveChanges();
                }
                message.AppendLine("Our EnchantedEscala-Cruises has a new harbour to moor at...");
            }
            return message.ToString().TrimEnd();
        }
        public string DeleteHarbourById(int id)
        {
            using (context = new AppDbContext())
            {
                Harbour h = context.Harbours.Find(id);
                if (h == null)
                {
                    return $"{nameof(Harbour)} not found!";
                }
                context.Harbours.Remove(h);
                context.SaveChanges();
                return $"{nameof(Harbour)} {h.Name} {h.City.Name} {h.City.Country} is no longer EnchantedEscala-Cruises' property!";
            }
        }
    }
    
}
