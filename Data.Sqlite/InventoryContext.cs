﻿using Inventory.Data.Sqlite.Model;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Sqlite
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>().HasKey(e => new { e.CategoryID, e.SubCategoryID });
            modelBuilder.Entity<OrderItem>().HasKey(e => new { e.OrderID, e.OrderLine });
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<CountryCode> CountryCodes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<TaxType> TaxTypes { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
    }
}
