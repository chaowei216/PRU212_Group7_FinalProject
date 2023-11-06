using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class AnimalFood
    {
        public string AnimalId { get; set; } = null!;
        public string FoodId { get; set; } = null!;
        public DateTime StartEat { get; set; }
        public DateTime? EndEat { get; set; }
        public float Amount { get; set; }

        public virtual Animal Animal { get; set; } = null!;
        public virtual Food Food { get; set; } = null!;
    }
}
