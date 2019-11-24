using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_FoodStorage_Checkpoint2.Models;
using FoodStorage.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace FoodStorage.Infrastructure.Data
{
    class FoodRepository : IFoodRepository 
    {
        private readonly AppDbContext _dbContext;
        public FoodRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }


        public Food Add(Food entity)
        {
            _dbContext.Foods.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Food Get(int id)
        {
            return _dbContext.Foods.Include(f => f.foodName)
                        .FirstOrDefault(f => f.id == id);
        }

        public IEnumerable<Food> GetAll()
        {
            return _dbContext.Foods.Include(f => f.foodName).ToList();
        }

        public Food Update(Food updatedItem)
        {
            var existingItem = _dbContext.Foods.Find(updatedItem.id);
            if (existingItem == null) return null;
            _dbContext.Entry(existingItem)
                .CurrentValues.SetValues(updatedItem);
            _dbContext.Foods.Update(existingItem);
            _dbContext.SaveChanges();
            return existingItem;
        }

        public void Remove(Food entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
