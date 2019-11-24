using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_FoodStorage_Checkpoint2.Models;

namespace CS321_FoodStorage_Checkpoint2.ApiModels
{
    public class FoodTypeModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public ICollection<Food> foods { get; set; }
    }
}
