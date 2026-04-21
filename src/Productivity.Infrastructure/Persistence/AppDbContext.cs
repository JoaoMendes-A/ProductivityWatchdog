using Microsoft.EntityFrameworkCore;
using Productivity.Domain.Entities;

namespace Productivity.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlockedApplication> BlockedApplications { get; set; }
        public DbSet<FocusRule> FocusRules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}