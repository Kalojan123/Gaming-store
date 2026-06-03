using Gaming_store.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Gaming_store.Data
{
    public class GameContext:DbContext
    {
        public GameContext()
        {

        }
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {

        }
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
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("connectionString.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasKey(u => u.Id);
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
                g.Property(p => p.image).HasColumnType("image");                
                g.Property(g => g.ReleaseDate).HasColumnType("date").IsRequired();
                g.ToTable(g => g.HasCheckConstraint("Game_Price_CK", "[Price] > 0"));
            });
            modelBuilder.Entity<Wishlist>(g =>
            {
                g.HasOne(u => u.User).WithOne(w => w.Wishlist).HasForeignKey<Wishlist>(u => u.UserId);                
            });
            modelBuilder.Entity<Cart>(g =>
            {
                g.HasOne(u => u.User).WithOne(c => c.Cart).HasForeignKey<Cart>(u => u.UserId);                
            });
            modelBuilder.Entity<Library>(g =>
            {
                g.HasOne(u => u.User).WithOne(l => l.Library).HasForeignKey<Library>(u => u.UserId);
            });
            modelBuilder.Entity<WishlistGame>(wg =>
            {
                wg.HasKey(wg => wg.Id);                
                wg.HasOne(wg => wg.Wishlist).WithMany(w => w.WishlistsGames).HasForeignKey(wg => wg.WishlistId).OnDelete(DeleteBehavior.Cascade);
                wg.HasOne(wg => wg.Game).WithMany(g => g.WishlistsGames).HasForeignKey(wg => wg.GameId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<CartGame>(cg =>
            {
                cg.HasKey(cg => cg.Id);
                cg.HasOne(cg => cg.Cart).WithMany(c => c.CartsGames).HasForeignKey(cg => cg.CartId).OnDelete(DeleteBehavior.Cascade);
                cg.HasOne(cg => cg.Game).WithMany(g => g.CartsGames).HasForeignKey(cg => cg.GameId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<LibraryGame>(lg =>
            {
                lg.HasKey(lg => lg.Id);
                lg.HasOne(lg => lg.Library).WithMany(l => l.LibrariesGames).HasForeignKey(lg => lg.LibraryId).OnDelete(DeleteBehavior.Cascade);
                lg.HasOne(lg => lg.Game).WithMany(g => g.LibrariesGames).HasForeignKey(lg => lg.GameId).OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
