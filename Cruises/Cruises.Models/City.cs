namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Harbour> Harbours { get; set; } = new List<Harbour>();
    }
}
