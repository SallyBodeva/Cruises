namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class AdditionalService
    {
        private AppDbContext context;
        public City GetCityByName(string name)
        {
            using (context = new AppDbContext())
            {
                City c = this.context.Cities.FirstOrDefault(x => x.Name == name);
                return c;
            }
        }
        public string CreateCity(string cityName, string coutryName)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(cityName))
            {
                sb.AppendLine($"{nameof(City)} name is not valid!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(coutryName))
            {
                sb.AppendLine($"{nameof(coutryName)} name is not valid!");
                isValid = false;
            }
            using (context = new AppDbContext())
            {
                if (isValid)
                {
                    City c = new City()
                    {
                        Name = cityName,
                        Country = coutryName
                    };
                    this.context.Cities.Add(c);
                    this.context.SaveChanges();
                    sb.AppendLine($"City - {c.Name} added successfully");
                }
                return sb.ToString().TrimEnd();
            }
        }
        public string CreateShipTypes(string shipType)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(shipType))
            {
                sb.AppendLine($"Ship type is not valid!");
                isValid = false;
            }
            using (context= new AppDbContext())
            {
                if (isValid)
                {
                    ShipType sT = new ShipType() {Name= shipType};
                    this.context.ShipTypes.Add(sT);
                    this.context.SaveChanges();
                    sb.AppendLine($"Ship type - {sT.Name} added successfully");
                }
                return sb.ToString().TrimEnd();
            }
        }
      
        public List<string> GetCitiesNames()
        {
            using (context = new AppDbContext())
            {
                List<string> cities = context.Cities.Select(x=>x.Name).ToList();
                return cities;
            }
        }
        public List<string> GetCountriesNames()
        {
            using (context = new AppDbContext())
            {
                List<string> cities = context.Cities.Select(x => x.Country).ToList();
                return cities;
            }
        }
    }
}
