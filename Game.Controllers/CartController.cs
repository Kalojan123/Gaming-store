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
        public async Task<string> AddToCart(int userId, int gameId)
        {
            Cart cart = await context.Carts.FirstOrDefaultAsync(w => w.UserId == userId);            
            cart.CartsGames.Add(new CartGame { GameId = gameId });
            await context.SaveChangesAsync();
            return "Game added to cart.";
        }
        public async Task<string> RemoveFromCart(int userId, int gameId)
        {
            Cart cart = await context.Carts.FirstOrDefaultAsync(w => w.UserId == userId);
            CartGame cartGame = cart.CartsGames.FirstOrDefault(wg => wg.GameId == gameId);           
            cart.CartsGames.Remove(cartGame);
            await context.SaveChangesAsync();
            return "Game removed from cart.";
        }
    }
}
