using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Food
    {
        public Food()
        {
            AnimalFoods = new HashSet<AnimalFood>();
        }

        public string FoodId { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<AnimalFood> AnimalFoods { get; set; }
    }
}
