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
    public class CartController
    {
        private GameContext context;
        public CartController()
        {
            context = new GameContext();
        }
        public async Task<List<CartGame>> GetUserCart(int userId)
        {
            Cart cart = await context.Carts.FirstOrDefaultAsync(c => c.UserId == userId);
            if (cart == null)
            {
                return new List<CartGame>();
            }
            return cart.CartsGames.ToList();
        }
        public async Task<string> AddToCart(int userId, int gameId)
        {
            Cart cart = await context.Carts.FirstOrDefaultAsync(w => w.UserId == userId);
            if (cart.CartsGames.Any(wg => wg.GameId == gameId))
            {
                return "Game already in cart.";
            }
            cart.CartsGames.Add(new CartGame { GameId = gameId });
            await context.SaveChangesAsync();
            return "Game added to cart.";
        }
        public async Task<string> RemoveFromCart(int userId, int gameId)
        {
            Cart cart = await context.Carts.FirstOrDefaultAsync(w => w.UserId == userId);
            CartGame cartGame = cart.CartsGames.FirstOrDefault(wg => wg.GameId == gameId);
            if (cartGame == null)
            {
                return "Game not found in cart.";
            }
            cart.CartsGames.Remove(cartGame);
            await context.SaveChangesAsync();
            return "Game removed from cart.";
        }
    }
}
