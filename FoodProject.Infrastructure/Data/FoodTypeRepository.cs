using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CS321_FoodStorage_Checkpoint2.Models;
using FoodStorage.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace FoodStorage.Infrastructure.Data
{
    class FoodTypeRepository : IFoodTypeRepository
    {
        private readonly AppDbContext _dbContext;
        public FoodTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public FoodType Add(FoodType entity)
        {
            _dbContext.FoodTypes.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public FoodType Get(int id)
        {
            return _dbContext.FoodTypes
                .Include(a => a.foods)
                .FirstOrDefault(a => a.id == id);
        }

        public IEnumerable<FoodType> GetAll()
        {
            return _dbContext.FoodTypes
                .Include(a => a.foods).ToList();
        }

        public FoodType Update(FoodType entity)
        {
            var existingItem = _dbContext.FoodTypes.Find(entity.id);
            if (existingItem == null) return null;
            _dbContext.Entry(existingItem).CurrentValues.SetValues(entity);
            _dbContext.FoodTypes.Update(existingItem);
            _dbContext.SaveChanges();
            return existingItem;
        }

        public void Remove(FoodType entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
