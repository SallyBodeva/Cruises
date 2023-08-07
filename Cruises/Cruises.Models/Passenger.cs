namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public bool IsStudent { get; set; }
        public bool IsRetiree { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
