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
        public async Task<List<WishlistGame>> GetUserWishlist(int userId)
        {
            Wishlist wishlist = await context.Wishlists.FirstOrDefaultAsync(w => w.UserId == userId);       
            if(wishlist == null)
            {
                return new List<WishlistGame>();
            }
            return wishlist.WishlistsGames.ToList();
        }
        public async Task<string> AddToWishlist(int userId, int gameId)
        {
            Wishlist wishlist = await context.Wishlists.FirstOrDefaultAsync(w => w.UserId == userId);
            if (wishlist.WishlistsGames.Any(wg => wg.GameId == gameId))
            {
                return "Game already in wishlist.";
            }
            wishlist.WishlistsGames.Add(new WishlistGame { GameId = gameId });
            await context.SaveChangesAsync();
            return "Game added to wishlist.";
        }
        public async Task<string> RemoveFromWishlist(int userId, int gameId)
        {
            Wishlist wishlist = await context.Wishlists.FirstOrDefaultAsync(w => w.UserId == userId);
            WishlistGame wishlistGame = wishlist.WishlistsGames.FirstOrDefault(wg => wg.GameId == gameId);
            if (wishlistGame == null)
            {
                return "Game not found in wishlist.";
            }
            wishlist.WishlistsGames.Remove(wishlistGame);
            await context.SaveChangesAsync();
            return "Game removed from wishlist.";
        }
    }
}
