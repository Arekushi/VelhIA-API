using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Data.Context
{
    public class AppDbContext : DbContext
    {
        #region Properties

        public DbSet<Board> Boards { get; set; }

        public DbSet<Column> Columns { get; set; }

        public DbSet<Line> Lines { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerMove> PlayerMoves { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Match - Player

            builder.Entity<MatchPlayer>()
                .HasKey(mp => new { mp.MatchId, mp.PlayerId });

            builder.Entity<MatchPlayer>()
                .HasOne(mp => mp.Match)
                .WithMany(m => m.Players)
                .HasForeignKey(mp => mp.MatchId);

            builder.Entity<MatchPlayer>()
                .HasOne(mp => mp.Player)
                .WithMany(p => p.Matches)
                .HasForeignKey(mp => mp.PlayerId);

            #endregion

            #region Board - Match

            builder.Entity<Match>()
                .HasOne(m => m.Board)
                .WithOne(b => b.Match)
                .HasForeignKey<Board>(b => b.MatchId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("CreatedOn") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedOn").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("UpdatedOn") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("UpdatedOn").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdatedOn").CurrentValue = DateTime.Now;
                }

            }

            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("Enabled") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Enabled").CurrentValue = true;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
