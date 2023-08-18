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

        public string CreateHarbour(string name, string city, string country)
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
                message.AppendLine("Inavlid name of the city");
                isValid = false;
            }
            City c = null;
            using (context = new AppDbContext())
            {
                c = this.context.Cities.FirstOrDefault(x => x.Name == city && x.Country == country);
                if (c == null)
                {
                    c = new City() { Name = city, Country = country };
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
                    message.AppendLine($"Our EnchantedEscala-Cruises has a new harbour to moor at...{h.Name}");
                }
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
        public string GetHarbourInfo(int id)
        {
            Harbour h = null;
            using (context = new AppDbContext())
            {
                h = context.Harbours.Find(id);

                if (h != null)
                {
                    StringBuilder message = new StringBuilder();
                    message.AppendLine($"{nameof(Harbour)} info: ");
                    message.AppendLine($"\tId: {h.Id}");
                    message.AppendLine($"\tName: {h.Name}");
                    message.AppendLine($"\tCity: {h.City.Name}");
                    message.AppendLine($"\tCountry: {h.City.Country}");
                    return message.ToString().TrimEnd();
                }
                else
                {
                    return $"{nameof(Harbour)} not found!";
                }
            }
        }
        public string GetAllHarboursInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-25} | {"City: ",-25} | {"Country",-25} |";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Harbour> harbours = context.Harbours.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var h in harbours)
                {
                    string info = $"| {h.Id,-4} | {h.Name,-25} | {h.City.Name,-25} | {h.City.Country,-25} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Harbours.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }

    }

}
