using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cruises.Models
{
    public class CrewMember
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }

        public virtual ICollection<ShipCrewMember> ShipCrewMembers { get; set; } = new List<ShipCrewMember>();
    }
}
