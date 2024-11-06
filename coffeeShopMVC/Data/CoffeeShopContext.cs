using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coffeeShopMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace coffeeShopMVC.Data
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        // Add more DbSets for other entities here
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.price).HasColumnType("decimal(18, 2)");  // Adjust precision and scale as needed
        }


    }
    
}