namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class VoyageCrewMember
    {
        public int VoyageId { get; set; }
        public virtual Voyage Voyage { get; set; }

        public int CrewMemberId { get; set; }
        public virtual CrewMember CrewMember { get; set; }
    }
}
