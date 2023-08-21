namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Voyage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int HarbourId { get; set; }
        public virtual Harbour Harbour { get; set; }
        public int DestinationHarbourId { get; set; }
        public virtual Harbour DestinationHarbour { get; set; }
        public int Duration { get; set; }
        public int ShipId { get; set; }

        public virtual Ship Ship { get; set; }

        public decimal TicketPrice { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
