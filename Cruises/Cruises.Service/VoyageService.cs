namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Text;
    public class VoyageService
    {
        private AppDbContext context;

        public string CreateVoyage(string name, string fromHarbourName, string toHarbourName, int duration, string shipName, decimal ticketPrice)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(fromHarbourName))
            {
                message.AppendLine("Inavlid name  of starting Harbour");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(toHarbourName))
            {
                message.AppendLine("Inavlid name of destination Harbour");
                isValid = false;
            }
            if (duration <= 0)
            {
                message.AppendLine("Inavlid duration of voyage");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(shipName))
            {
                message.AppendLine("Inavlid name of ship");
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
                    Harbour s = this.context.Harbours.FirstOrDefault(x => x.Name == fromHarbourName);
                    Harbour d = this.context.Harbours.FirstOrDefault(x => x.Name == toHarbourName);
                    Ship sh = this.context.Ships.FirstOrDefault(x => x.Name == shipName);

                    if (s.Name == d.Name)
                    {
                        message.AppendLine($"Cannot assign a travel from one Harbour to the same Harbour");
                    }
                    else
                    {
                        Voyage v = new Voyage()
                        {
                            Name = name,
                            Harbour = s,
                            DestinationHarbour = d,
                            Duration = duration,
                            Ship = sh,
                            TicketPrice = ticketPrice
                        };
                        context.Voyages.Add(v);
                        context.SaveChanges();
                        message.AppendLine($"Our EnchantedEscala-Cruises has a new voyage- from {v.Harbour.Name} to {v.DestinationHarbour.Name}");
                    }
                }
            }
            return message.ToString().TrimEnd();
        }
        public string DeleteVoyageById(int id)
        {
            using (context = new AppDbContext())
            {
                Voyage v = this.context.Voyages.FirstOrDefault(x => x.Id == id);
                if (v == null)
                {
                    return $"{nameof(Voyage)} not found!";
                }
                context.Voyages.Remove(v);
                context.SaveChanges();
                return $"{nameof(Voyage)} from {v.Harbour.Name} harbour to {v.DestinationHarbour.Name} harbour  is deleted!";
            }
        }
        public Voyage GetVoyageById(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Invalid v id!");
            }
            Voyage v = this.context.Voyages.Find(id);
            return v;
        }
        public string GetVoyageInfo(int id)
        {
            Voyage v = null;
            using (context = new AppDbContext())
            {
                v = context.Voyages.Find(id);
            }
            if (v != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine($"{nameof(Voyage)} info: ");
                message.AppendLine($"\tId: {v.Id}");
                message.AppendLine($"\tFrom: {v.HarbourId} (harbour id)");
                message.AppendLine($"\tTo: {v.DestinationHarbourId} (harbour id)");
                message.AppendLine($"\tDuration: {v.Duration} hours");
                message.AppendLine($"\tShip id: {v.ShipId}");
                message.AppendLine($"\tTicket price: {v.TicketPrice}");
                return message.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Voyage)} not found!";
            }
        }
        public string UpdateTicketPriceByVoyageId(int id, decimal newTicketPrice)
        {
            using (context = new AppDbContext())
            {
                Voyage v = this.context.Voyages.FirstOrDefault(x => x.Id == id);
                if (v != null)
                {
                    v.TicketPrice = newTicketPrice;
                    context.Update(v);
                    context.SaveChanges();
                    return $"{nameof(Voyage)} from {v.Harbour.Name} to {v.DestinationHarbour.Name} has new price for a ticke!";
                }
                else
                {
                    return "This voyage does not exist...";
                }
            }
        }

        public string CreateReservation(int passengerId, int voyageId, DateTime reservationDate)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (passengerId < 1)
            {
                message.AppendLine("Invalid passenger id");
                isValid = false;
            }
            if (voyageId < 1)
            {
                message.AppendLine("Invalid voyage id");
                isValid = false;
            }

            using (context = new AppDbContext())
            {
                if (isValid)
                {
                    Reservation r = new Reservation()
                    {
                        PassengerId = passengerId,
                        VoyageId = voyageId,
                        ReservationDate = reservationDate
                    };
                    context.Reservations.Add(r);
                    context.SaveChanges();
                    message.AppendLine($"Passenger got on board with his reservation on {reservationDate:g}");
                }
            }
            return message.ToString().TrimEnd();
        }
        public List<Voyage> GetVoyages()
        {
            using (context = new AppDbContext())
            {
                List<Voyage> voyages = context.Voyages.ToList();
                return voyages;
            }
        }
        public int GetVoyageId(Voyage voyage)
        {
            using (context = new AppDbContext())
            {
                return voyage.Id;
            }
        }
        public int GetVoyageDurationById(int voyageId)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(voyageId);
                return v.Duration;
            }
        }
        public string GetVoyageShupNameById(int voyageId)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(voyageId);
                return v.Ship.Name;
            }
        }
        public decimal GetVoyageTicketPriceById(int voyageId)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(voyageId);
                return v.TicketPrice;
            }
        }
        public string GetVoyageHarboursNameById(int id)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(id);
                string name = v.Harbour.Name;
                return name;
            }
        }
        public string GetVoyageDestHarboursNameById(int id)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(id);
                string name = v.DestinationHarbour.Name;
                return name;
            }
        }
        public string GetVoyageNameById(int id)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(id);
                string name = v.Name;
                return name;
            }
        }
        public int GetVoyageIdByName(string name)
        {
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.FirstOrDefault(x => x.Name == name);
                int id = v.Id;
                return id;
            }
        }
        public List<string> GetVoyagesName()
        {
            using (context = new AppDbContext())
            {
                List<string> names = context.Voyages.Select(x => x.Name).ToList();
                return names;
            }
        }
        public int GetLastAddedPassenger()
        {
            using (context = new AppDbContext())
            {
                List<Reservation> reservations = context.Reservations.ToList();
                Reservation last = reservations.Last();
                return last.PassengerId;
            }
        }
        public int GetVoyagesPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Voyages.Count() / (double)count);
            }
        }
        public List<string> GetVoyagesInfo()
        {
            using (context = new AppDbContext())
            {
                List<string> list = context.Voyages.Select(x => $"{x.Id} - {x.Name}").ToList();
                return list;
            }
        }
    }
}
