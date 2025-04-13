using crud.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ApplicationStudent> ApplicationStudents { get; set; }
    }
}
