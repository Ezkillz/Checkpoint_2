using System;
using System.Collections.Generic;
using System.Text;
using CS321_FoodStorage_Checkpoint2.Models;

namespace FoodStorage.Core.Services
{
    public interface IFoodRepository
    {
        Food Add(Food entity);
        Food Get(int id);
        IEnumerable<Food> GetAll();
        Food Update(Food entity);
        void Remove(Food entity);
    }
}
