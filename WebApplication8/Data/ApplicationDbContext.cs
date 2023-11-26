namespace WebApplication8.Data
{
    using Microsoft.EntityFrameworkCore;
    using WebApplication8.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
    }
}
