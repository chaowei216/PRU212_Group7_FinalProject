using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Cage
    {
        public Cage()
        {
            AnimalCages = new HashSet<AnimalCage>();
        }

        public string Cid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int MaxCapacity { get; set; }
        public int AnimalQuantity { get; set; }
        public string AreaId { get; set; } = null!;

        public virtual Area Area { get; set; } = null!;
        public virtual ICollection<AnimalCage> AnimalCages { get; set; }
    }
}
