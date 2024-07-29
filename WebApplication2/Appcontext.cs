using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class Appcontext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } // DbSet is like a table
        public DbSet<Project> Projects { get; set; } 
        public DbSet<Department> Departments { get; set; } 
        public DbSet<CarLicense> CarLicenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
