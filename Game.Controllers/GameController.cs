using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Controllers
{
    public class GameController
    {
        private GameContext context;
        public GameController()
        {
            context = new GameContext();
        }      
        public async Task<List<Game>> GetAllGames()
        {
            return await context.Games.ToListAsync();
        }
        public async Task<string> AddGame(string gameName, Genres genre, decimal price, DateTime releaseDate)
        {
            Game game = new Game
            {
                Name = gameName,
                Genre = genre,
                Price = price,
                ReleaseDate = releaseDate
            };
            await context.Games.AddAsync(game);
            await context.SaveChangesAsync();
            return $"Game '{gameName}' added successfully.";
        }
        public async Task<string> RemoveGame(int gameId)
        {
            Game game = await context.Games.FirstOrDefaultAsync(g => g.Id == gameId);
            if (game == null)
            {
                return "No game found.";
            }
            context.Games.Remove(game);
            await context.SaveChangesAsync();
            return $"Game '{game.Name}' removed successfully.";
        }
        public async Task<string> UpdatePrice(int gameId, decimal newPrice)
        {
            Game game = await context.Games.FirstOrDefaultAsync(g => g.Id == gameId);
            if (game == null)
            {
                return "No game found.";
            }
            game.Price = newPrice;
            await context.SaveChangesAsync();
            return $"Game '{game.Name}' price updated to {newPrice:C}.";
        }        
    }
}
