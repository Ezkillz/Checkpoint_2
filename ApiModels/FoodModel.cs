using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_FoodStorage_Checkpoint2.ApiModels
{
    public class FoodModel
    {
        public int id { get; set; }
        public string foodName { get; set; }
        public DateTime recieve { get; set; }
        public DateTime expiration { get; set; }
        public string foodTypeId { get; set; }
        public string foodType { get; set; }
    }
}
