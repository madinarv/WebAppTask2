using Microsoft.EntityFrameworkCore;
using WebApplicationtask2.Models;

namespace WebApplicationtask2.DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
        public DbSet<Model> Models { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}
