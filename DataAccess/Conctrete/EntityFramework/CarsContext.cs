﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Cars;Trusted_Connection=true");
         
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public DbSet<CarImages> CarImages { get; set; } 

        public DbSet<OperationClaim>     OperationClaims { get; set; }      
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }

      
    }
}
