namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Ship
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }
        public int ShipTypeId { get; set; }
        public virtual ShipType ShipType { get; set; }

        public virtual ICollection<ShipCrewMember> ShipCrewMembers { get; set; } = new List<ShipCrewMember>();

    }
}
