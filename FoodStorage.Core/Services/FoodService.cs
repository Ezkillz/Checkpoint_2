using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using FoodStorage.Core.Services;


namespace FoodStorage.Core.Services
{
    class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public Food Add(Food food)
        {
            return _foodRepository.Add(food);
        }
        public Food Get(int id)
        {
            return _foodRepository.Get(id);
        }
        public IEnumerable<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }
        public Food Update(Food updatedFood)
        {
            return _foodRepository.Update(updatedFood);
        }
        public void Remove(int id)
        {
            var question = _foodRepository.Get(id);
            _foodRepository.Remove(question);
        }
    }
}
