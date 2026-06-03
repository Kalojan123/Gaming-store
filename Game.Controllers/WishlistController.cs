using Gaming_store.Data;
using Gaming_store.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Controllers
{
    public class WishlistController
    {
        private GameContext context;
        public WishlistController()
        {
            context = new GameContext();
        }        
        public async Task<bool> IsInWishlist(int userId, int gameId)
        {
            Wishlist wishlist = await context.Wishlists.Include(x => x.WishlistsGames).FirstAsync(w => w.UserId == userId);
            return wishlist.WishlistsGames.Any(wg => wg.GameId == gameId);
        }
        public async Task<string> CreateWishlist(int userId)
        {
            await context.Wishlists.AddAsync(new Wishlist { UserId = userId });
            await context.SaveChangesAsync();
            return "Wishlist created successfully.";
        }
        public async Task<string> AddToWishlist(int userId, int gameId)
        {
            Wishlist wishlist = await context.Wishlists.Include(x => x.WishlistsGames).FirstAsync(w => w.UserId == userId);         
            wishlist.WishlistsGames.Add(new WishlistGame { GameId = gameId });
            await context.SaveChangesAsync();
            return "Game added to wishlist.";
        }
        public async Task<string> RemoveFromWishlist(int userId, int gameId)
        {
            Wishlist wishlist = await context.Wishlists.Include(x => x.WishlistsGames).FirstAsync(w => w.UserId == userId);
            WishlistGame wishlistGame = wishlist.WishlistsGames.First(wg => wg.GameId == gameId);            
            wishlist.WishlistsGames.Remove(wishlistGame);
            await context.SaveChangesAsync();
            return "Game removed from wishlist.";
        }
    }
}
