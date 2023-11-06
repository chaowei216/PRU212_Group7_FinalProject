using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Area
    {
        public Area()
        {
            Cages = new HashSet<Cage>();
        }

        public string AreaId { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Cage> Cages { get; set; }
    }
}
