using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_FoodStorage_Checkpoint2.Models;

namespace CS321_FoodStorage_Checkpoint2.ApiModels
{
    public static class FoodMappingExtention
    {
        public static FoodModel ToApiModel(this Food food)
        {
            return new FoodModel
            {
                id = food.id,
                foodName = food.foodName,
                recieve = food.recieve,
                expiration = food.expiration,
                foodTypeId = food.foodTypeId,
                foodType = food.foodType
            };
        }
        public static Food ToDomainModel(this FoodModel foodModel)
        {
            return new Food
            {
                id = foodModel.id,
                foodName = foodModel.foodName,
                recieve = foodModel.recieve,
                expiration = foodModel.expiration,
                foodTypeId = foodModel.foodTypeId,
                foodType = foodModel.foodType
            };
        }
        public static IEnumerable<FoodModel> ToApiModels(this IEnumerable<Food> foods)
        {
            return foods.Select(f => f.ToApiModel()); 
        }
        public static IEnumerable<Food> ToDomainModels(this IEnumerable<FoodModel> foodModels)
        {
            return foodModels.Select(fm => fm.ToDomainModel());
        }
    }
}
