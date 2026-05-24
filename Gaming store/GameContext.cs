using Gaming_store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Data
{
    public class GameContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Cart> Carts { get; set; }        
        public DbSet<Library> Libraries { get; set; }
        public DbSet<WishlistGame> WishlistGames { get; set; }
        public DbSet<CartGame> CartGames { get; set; }
        public DbSet<LibraryGame> LibraryGames { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("connectionString.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasKey(u => u.Id);                
                u.HasOne(u => u.Wishlist).WithOne(w => w.User).HasForeignKey<User>(u => u.WishlistId);
                u.HasOne(u => u.Cart).WithOne(c => c.User).HasForeignKey<User>(u => u.CartId);
                u.HasOne(u => u.Library).WithOne(l => l.User).HasForeignKey<User>(u => u.LibraryId);
                u.Property(u => u.Username).IsUnicode().IsRequired().HasMaxLength(30);
                u.Property(u => u.Password).IsUnicode().IsRequired().HasMaxLength(30);
                u.Property(u => u.Email).IsUnicode().IsRequired().HasMaxLength(50);
                u.Property(u => u.Balance).HasColumnType("decimal(10,2)");  
                u.Property(u => u.Role).IsRequired().HasConversion<string>();
                u.ToTable(u => u.HasCheckConstraint("User_Balance_CK", "[Balance] >= 0"));  
            });
            modelBuilder.Entity<Game>(g =>
            {
                g.HasKey(g => g.Id);                
                g.Property(g => g.Name).IsUnicode().IsRequired().HasMaxLength(50);
                g.Property(g => g.Genre).IsRequired().HasConversion<string>();
                g.Property(g => g.Price).HasColumnType("decimal(5,2)");
                g.Property(g => g.ReleaseDate).IsRequired();
                g.ToTable(g => g.HasCheckConstraint("Game_Price_CK", "[Price] > 0"));
            });
            modelBuilder.Entity<WishlistGame>(wg =>
            {
                wg.HasKey(wg => new { wg.WishlistId, wg.GameId });
                wg.HasOne(wg => wg.Wishlist).WithMany(w => w.WishlistsGames).HasForeignKey(wg => wg.WishlistId);
                wg.HasOne(wg => wg.Game).WithMany(g => g.WishlistsGames).HasForeignKey(wg => wg.GameId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<CartGame>(cg =>
            {
                cg.HasKey(cg => new { cg.CartId, cg.GameId });
                cg.HasOne(cg => cg.Cart).WithMany(c => c.CartsGames).HasForeignKey(cg => cg.CartId);
                cg.HasOne(cg => cg.Game).WithMany(g => g.CartsGames).HasForeignKey(cg => cg.GameId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<LibraryGame>(lg =>
            {
                lg.HasKey(lg => new { lg.LibraryId, lg.GameId });
                lg.HasOne(lg => lg.Library).WithMany(l => l.LibrariesGames).HasForeignKey(lg => lg.LibraryId);
                lg.HasOne(lg => lg.Game).WithMany(g => g.LibrariesGames).HasForeignKey(lg => lg.GameId).OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
