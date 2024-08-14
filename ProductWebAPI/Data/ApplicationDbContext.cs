using Microsoft.EntityFrameworkCore;
using ProductWebAPI.Models.Entity;

namespace ProductWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet <product> Products { get; set; }
    }
}
