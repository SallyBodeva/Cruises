namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Reservation
    {
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }

        public int VoyageId { get; set; }
        public virtual Voyage Voyage { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.UtcNow;
    }
}
