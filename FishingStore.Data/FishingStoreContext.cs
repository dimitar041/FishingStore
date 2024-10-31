using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using FishingStore.Data.Models;
using System.Reflection;

namespace FishingStore.Data
{
    public class FishingStoreContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FishingStoreContext()
        {

        }

        public FishingStoreContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<Rod> Rods { get; set; }

        public virtual DbSet<Reel> Reels { get; set; }

        public virtual DbSet<Line> Lines { get; set; }

        public virtual DbSet<Hook> Hooks { get; set; }

        public virtual DbSet<FullSet> FullSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
