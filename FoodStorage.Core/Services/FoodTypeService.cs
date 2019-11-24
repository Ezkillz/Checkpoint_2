using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage.Core.Services;
using CS321_FoodStorage_Checkpoint2.Models;

namespace CS321_FoodStorage_Checkpoint2.Services
{
    public class FoodTypeService
    {
        private readonly IFoodTypeRepository _foodTypeRepository;
        public FoodTypeService(IFoodTypeRepository foodTypeRepository)
        {
            _foodTypeRepository = foodTypeRepository;
        }
        public FoodType Get(int id)
        {
            return _foodTypeRepository.Get(id);
        }

        public IEnumerable<FoodType> GetAll()
        {
            return _foodTypeRepository.GetAll();
        }
    }
}
