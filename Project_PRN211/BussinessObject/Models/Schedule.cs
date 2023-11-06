using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            AnimalSchedules = new HashSet<AnimalSchedule>();
        }

        public string ScheduleId { get; set; } = null!;
        public string ScheduleName { get; set; } = null!;
        public bool Status { get; set; }

        public virtual ICollection<AnimalSchedule> AnimalSchedules { get; set; }
    }
}
