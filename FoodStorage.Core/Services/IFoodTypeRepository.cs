using System;
using System.Collections.Generic;
using System.Text;
using CS321_FoodStorage_Checkpoint2.Models;

namespace FoodStorage.Core.Services
{
    public interface IFoodTypeRepository
    {
        FoodType Add(FoodType entity);
        FoodType Get(int id);
        IEnumerable<FoodType> GetAll();
        FoodType Update(FoodType entity);
        void Remove(FoodType entity);

    }
}
