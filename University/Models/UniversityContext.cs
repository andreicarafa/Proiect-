using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace University.Models
{
    public class UniversityContext : DbContext
    {
        private readonly IConfiguration configuration;
           public UniversityContext(DbContextOptions<UniversityContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("UniversityDatabaseConnection"));
        }
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }

}