using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class AnimalTrainer
    {
        public string UserId { get; set; } = null!;
        public string AnimalId { get; set; } = null!;
        public DateTime StartTrainDate { get; set; }
        public DateTime? EndTrainDate { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
