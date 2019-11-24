using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_FoodStorage_Checkpoint2.Models;

namespace CS321_FoodStorage_Checkpoint2.Services
{
    public interface IFoodService
    {
        Food Get(int id);
        IEnumerable<Food> GetAll();
        Food Add(Food newFood);
        Food Update(Food updatedFood);
        void Remove(int id);

    }
}
