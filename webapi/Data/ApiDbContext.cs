using Microsoft.EntityFrameworkCore;
using webapi.Modals.Domain;

namespace webapi.Data
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions dbContextoptions):base(dbContextoptions)
        {
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
