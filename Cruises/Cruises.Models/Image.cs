using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cruises.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        public int ImageId { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
