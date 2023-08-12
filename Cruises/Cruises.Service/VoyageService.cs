namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class VoyageService
    {
        private AppDbContext context;

        public string CreateNewVoyage(int startHarbourId, int destinationHarbourId, int duration, int shipId,decimal ticketPrice)
        {

            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (startHarbourId<1)
            {
                message.AppendLine($"Invalid id of the start harbour!");
                isValid = false;
            }
            if (destinationHarbourId<1)
            {
                message.AppendLine($"Invalid id of destination !");
                isValid = false;
            }
            if (duration<1)
            {
                message.AppendLine($"Invalid duration time!");
                isValid = false;
            }
            if (shipId < 1)
            {
                message.AppendLine($"Invalid ship id!");
                isValid = false;
            }
            if (ticketPrice <= 0)
            {
                message.AppendLine($"Invalid ticket price!");
                isValid = false;
            }
            using (context = new AppDbContext())
            {
                if (isValid)
                {
                    Voyage v = new Voyage
                    {
                        HarbourId = startHarbourId,
                        DestinationHarbourId = destinationHarbourId,
                        Duration = duration,
                        ShipId= shipId,
                        TicketPrice= ticketPrice
                    };
                    this.context.Voyages.Add(v);
                    this.context.SaveChanges();
                    message.AppendLine($"New voyage from {v.Harbour.Name} to {v.DestinationHarbour.Name} is created");
                }
                return message.ToString().TrimEnd();
            }
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
                message.AppendLine($"\tFrom: {v.Harbour.Name}");
                message.AppendLine($"\tTo: {v.DestinationHarbour.Name}");
                message.AppendLine($"\tDuration: {v.Duration} hours");
                message.AppendLine($"\tShip: {v.Ship.Name}");
                message.AppendLine($"\tTicket price: {v.TicketPrice}");
                return message.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Voyage)} not found!";
            }
        }
       // public string UpdateTicketPrice()
    }
}
