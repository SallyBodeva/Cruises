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
                        PassengerId=passengerId,
                        VoyageId= voyageId,
                        ReservationDate= reservationDate
                    };
                    context.Reservations.Add(r);
                    context.SaveChanges();
                    message.AppendLine($"Passenger got on board with his reservation on {reservationDate:g}");
                }
            }
            return message.ToString().TrimEnd();
        }
    }
}
