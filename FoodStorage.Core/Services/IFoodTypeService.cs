using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_FoodStorage_Checkpoint2.Models;
namespace CS321_FoodStorage_Checkpoint2.Services
{
    public interface IFoodTypeService
    {
        FoodType Get(int id);
        IEnumerable<FoodType> GetAll();
        FoodType Add(FoodType newFoodType);
        FoodType Update(FoodType updatedFoodType);  
    }
}
