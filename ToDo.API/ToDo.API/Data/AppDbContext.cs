using Microsoft.EntityFrameworkCore;

namespace ToDo.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Entities.ToDo> ToDos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
