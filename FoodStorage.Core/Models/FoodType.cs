using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_FoodStorage_Checkpoint2.Models
{
    public class FoodType
    {
        public int id { get; set; }
        public string title { get; set; }
        public ICollection<Food> foods { get; set; }
    }
}
