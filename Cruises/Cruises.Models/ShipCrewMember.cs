namespace Cruises.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ShipCrewMember
    {
        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }

        public int CrewMemberId { get; set; }
        public virtual CrewMember CrewMember { get; set; }
    }
}
