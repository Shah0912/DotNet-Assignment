using EmployeeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVC.DataAccessLayer
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("employees");
        }
    }
}
