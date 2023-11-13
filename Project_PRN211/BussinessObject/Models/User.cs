using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class User
    {
        public User()
        {
            AnimalTrainers = new HashSet<AnimalTrainer>();
        }

        public string UserId { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool Sex { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
        public int Role { get; set; }
        public int CountAnimal { get; set; }
        public string Password { get; set; } = null!;

        public virtual ICollection<AnimalTrainer> AnimalTrainers { get; set; }
    }
}
