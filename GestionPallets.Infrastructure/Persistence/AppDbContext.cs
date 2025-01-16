using GestionPallets.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionPallets.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<StockEntity> Stocks { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public DbSet<PalletEntity> Pallets { get; set; }
        public DbSet<MotionEntity> Motions { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
