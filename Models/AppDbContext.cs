using Microsoft.EntityFrameworkCore;
using ValkyrieIMS.Models;

namespace SecFromScratch {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}