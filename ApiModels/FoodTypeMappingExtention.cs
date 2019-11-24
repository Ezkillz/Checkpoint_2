using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_FoodStorage_Checkpoint2.Models;

namespace CS321_FoodStorage_Checkpoint2.ApiModels
{
    public static class FoodTypeMappingExtention
    {
        public static FoodTypeModel ToApiModel(this FoodType foodType)
        {
            return new FoodTypeModel
            {
                id = foodType.id,
                title = foodType.title,
                foods = foodType.foods.ToList()
            };
        }
        public static FoodType ToDomainModel(this FoodTypeModel foodTypeModel)
        {
            return new FoodType
            {
                id = foodTypeModel.id,
                title = foodTypeModel.title,
                foods = foodTypeModel.foods.ToList()
            };
        }
        public static IEnumerable<FoodTypeModel> ToApiModels(this IEnumerable<FoodType> foodTypes)
        {
            return foodTypes.Select(f => f.ToApiModel());   
        }
        public static IEnumerable<FoodType> ToDomainModels(this IEnumerable<FoodTypeModel> foodTypeModels)
        {
            return foodTypeModels.Select(fm => fm.ToDomainModel());
        }
    }
}
