using Microsoft.EntityFrameworkCore;

namespace Lab012.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Train> Trains { get; set; } = null!;
        public DbSet<Passenger> Passengers { get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
