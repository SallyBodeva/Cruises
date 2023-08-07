
namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    public class Harbour
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

        [InverseProperty("Harbour")]
        public virtual ICollection<Voyage> Harbours { get; set; } = new List<Voyage>();

        [InverseProperty("DestinationHarbour")]
        public virtual ICollection<Voyage> DestinationHarbours { get; set; } = new List<Voyage>();

    }
}
