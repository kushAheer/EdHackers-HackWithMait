using EdTech.Models;
using Microsoft.EntityFrameworkCore;

namespace EdTech.Assests
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }


        public DbSet<Users> Users { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
    }
}
