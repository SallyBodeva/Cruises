

namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class ShipType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();
    }
}
