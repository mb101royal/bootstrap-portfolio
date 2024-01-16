using Microsoft.EntityFrameworkCore;

namespace bootstrap_portfolio.Contexts
{
    public class BootstrapDbContext : DbContext
    {
        public BootstrapDbContext(DbContextOptions<BootstrapDbContext> options) : base(options) { }

        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
