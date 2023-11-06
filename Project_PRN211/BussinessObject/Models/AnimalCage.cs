using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class AnimalCage
    {
        public string AnimalId { get; set; } = null!;
        public string CageId { get; set; } = null!;
        public DateTime EntryCageDate { get; set; }
        public DateTime? OutCageDate { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual Cage Cage { get; set; } = null!;
    }
}
