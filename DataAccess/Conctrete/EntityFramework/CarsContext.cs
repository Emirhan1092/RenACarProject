using ConsoleApp1.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;



namespace DataAccess.Concrete.Entityframework
{
    public class CarsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Car;Trusted_Connection=True");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand{ get; set; }
       
    }
}
