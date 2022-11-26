using CarRentBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentBackend.Contexts
{
    public class TawsilaContext : DbContext
    {
        public TawsilaContext(DbContextOptions<TawsilaContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;
        public DbSet<Review> Reviews { get; set; } = null;

    }
}
