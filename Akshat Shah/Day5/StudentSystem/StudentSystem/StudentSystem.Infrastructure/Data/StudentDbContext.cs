using Microsoft.EntityFrameworkCore;
using StudentSystem.Core.Entities;
using Microsoft.Extensions.Configuration;

namespace StudentSystem.Infrastructure.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new
            {
                Id = 1,
                Name = "Akshat Shah",
                Gpa = 9.22f,
                EmailAddress = "a@a.com"
            });
        }
    }
}
