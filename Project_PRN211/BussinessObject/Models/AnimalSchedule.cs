using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class AnimalSchedule
    {
        public string AnimalId { get; set; } = null!;
        public string ScheduleId { get; set; } = null!;
        public string Time { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual Animal Animal { get; set; } = null!;
        public virtual Schedule Schedule { get; set; } = null!;
    }
}
