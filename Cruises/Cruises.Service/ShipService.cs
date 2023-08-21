using Cruises.Data;
using Cruises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cruises.Service
{
    public class ShipService
    {
        private AppDbContext context;


        public string CreateShip(string name, string model, int capacity,string url, string shipType)
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
                        ImageUrl= url,
                        ShipType = st
                    };
                    context.Ships.Add(s);
                    context.SaveChanges();
                    message.AppendLine($"Our EnchantedEscala-Cruises has a new ship-{s.Name}");
                }
            }
            return message.ToString().TrimEnd();
        }
        public List<string> GetShipNames()
        {
            using (context = new AppDbContext())
            {
                List<string> ships = context.Ships.Select(x => x.Name).ToList();
                return ships;
            }
        }
        public List<string> GetShipTypeName()
        {
            using (context = new AppDbContext())
            {
                List<string> names = this.context.ShipTypes.Select(x => x.Name).ToList();
                return names;
            }
        }

       
        public List<int> GetShipsId()
        {
            using (context = new AppDbContext())
            {
                List<int> shipsId = context.Ships.Select(x => x.Id).ToList();
                return shipsId;
            }
        }
        public string GetShipImageById(int id)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(id);
                string url = v.Ship.ImageUrl;
                return url;
            }
        }
    }
}
