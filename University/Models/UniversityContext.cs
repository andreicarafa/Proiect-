using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace University.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Course>? Courses { get; set; } 
        public DbSet<Grade>? Grades{ get; set; }
        public DbSet<Session>? Sessions{ get; set; }
        public DbSet<Student>? Students{ get; set; }
        public DbSet<Teacher>? Teachers{ get; set; }
        public DbSet<User>? Users{ get; set; }

    }
}