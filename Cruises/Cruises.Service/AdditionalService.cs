﻿namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;

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
        public string CreateShip(string name, string model, int capacity,string shipType,bool isFull)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine("Inavlid name of the new Harbour");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                message.AppendLine("Inavlid model of ship");
                isValid = false;
            }
            if (capacity <= 0)
            {
                message.AppendLine("Inavlid capacity of ship");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(shipType))
            {
                message.AppendLine("Inavlid type of ship");
                isValid = false;
            }
            ShipType st = null;
            using (context = new AppDbContext())
            {
                st = this.context.ShipTypes.FirstOrDefault(x => x.Name == shipType);
                if (st == null)
                {
                    st = new ShipType() { Name = shipType };
                }
                if (isValid)
                {
                    Ship s = new Ship()
                    {
                        Name = name,
                        Model = model,
                        Capacity = capacity,
                        ShipType=st,
                        Is_Full=isFull
                    };
                    context.Ships.Add(s);
                    context.SaveChanges();
                    message.AppendLine($"Our EnchantedEscala-Cruises has a new ship-{s.Name}");
                }
            }
            return message.ToString().TrimEnd();
        }
        public List<string> GetShipTypeName()
        {
            using (context = new AppDbContext())
            {
                List<string> names = this.context.ShipTypes.Select(x => x.Name).ToList();
                return names;
            }
        }
        public List<int> GetFromHarbours()
        {
            using (context= new AppDbContext())
            {
                List<int> fromHarboursIds = this.context.Harbours.OrderBy(x=>x.Id).Select(x => x.Id).ToList();
                return fromHarboursIds;
            }
        }
        public List<int> GetToHarbours(int fromHarbourtId)
        {
            using (context = new AppDbContext())
            {
                List<int> toHarboursIds = this.context.Harbours.Where(x=>x.Id!=fromHarbourtId).OrderBy(x => x.Id).Select(x => x.Id).ToList();
                return toHarboursIds;
            }
        }
        public string CreateVoyage(int fromHarbourId, int toHarbourId, int duration, int shipId, decimal ticketPrice)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (fromHarbourId<0)
            {
                message.AppendLine("Inavlid id  of starting Harbour");
                isValid = false;
            }
            if (toHarbourId < 0)
            {
                message.AppendLine("Inavlid id  of destination Harbour");
                isValid = false;
            }
            if (duration <= 0)
            {
                message.AppendLine("Inavlid duration of voyage");
                isValid = false;
            }
            if (shipId<0)
            {
                message.AppendLine("Inavlid id of ship");
                isValid = false;
            }
            if (ticketPrice <= 0)
            {
                message.AppendLine("Inavlid tikect price of voyage");
                isValid = false;
            }
            using (context = new AppDbContext())
            {
               
                if (isValid)
                {
                    Voyage v = new Voyage()
                    {
                        HarbourId=fromHarbourId,
                        DestinationHarbourId= toHarbourId,
                        Duration=duration,
                        ShipId=shipId,
                        TicketPrice= ticketPrice
                    };
                    context.Voyages.Add(v);
                    context.SaveChanges();
                    message.AppendLine($"Our EnchantedEscala-Cruises has a new voyage- from {v.Harbour.Name} to {v.DestinationHarbour.Name}");
                }
            }
            return message.ToString().TrimEnd();
        }
    }
}
