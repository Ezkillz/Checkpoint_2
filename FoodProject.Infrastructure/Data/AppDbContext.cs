using System;
using System.Collections.Generic;
using System.Text;
using CS321_FoodStorage_Checkpoint2.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodStorage.Infrastructure.Data
{
    class AppDbContext : DbContext // : IdentityDbContext <-- if i want user
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=../FoodStorage.Infrastructure/Inventory.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }  
    }
}
