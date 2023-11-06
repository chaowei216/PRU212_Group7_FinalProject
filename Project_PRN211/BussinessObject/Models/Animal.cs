using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Animal
    {
        public Animal()
        {
            AnimalCages = new HashSet<AnimalCage>();
            AnimalFoods = new HashSet<AnimalFood>();
            AnimalSchedules = new HashSet<AnimalSchedule>();
            AnimalTrainers = new HashSet<AnimalTrainer>();
        }

        public string AnimalId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Sex { get; set; }
        public string Region { get; set; } = null!;
        public string HealthCheck { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public bool Status { get; set; }
        public bool Rarity { get; set; }
        public string SpeciesName { get; set; } = null!;

        public virtual ICollection<AnimalCage> AnimalCages { get; set; }
        public virtual ICollection<AnimalFood> AnimalFoods { get; set; }
        public virtual ICollection<AnimalSchedule> AnimalSchedules { get; set; }
        public virtual ICollection<AnimalTrainer> AnimalTrainers { get; set; }
    }
}
