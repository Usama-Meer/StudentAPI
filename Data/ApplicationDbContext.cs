using Microsoft.EntityFrameworkCore;
using StudentAPI.Model;

namespace StudentAPI.Data
{
    /*public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        protected ApplicationDbContext()
        {
        }
    }*/

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
