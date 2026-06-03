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
    public class LibraryController
    {
        private GameContext context;
        public LibraryController()
        {
            context = new GameContext();
        }        
        public async Task<bool> IsInLibrary(int userId, int gameId)
        {
            Library library = await context.Libraries.Include(x => x.LibrariesGames).FirstAsync(w => w.UserId == userId);
            return library.LibrariesGames.Any(g => g.GameId == gameId);
        }
        public async Task<string> CreateLibrary(int userId)
        {
            await context.Libraries.AddAsync(new Library { UserId = userId });
            await context.SaveChangesAsync();
            return "Library created successfully.";
        }
        public async Task<string> AddToLibrary(int userId, int gameId)
        {
            User user = await context.Users.FindAsync(userId);
            Game game = await context.Games.FindAsync(gameId);
            if (user.Balance < game.Price)
            {
                return "Insufficient balance.";
            }
            user.Balance -= game.Price;
            Library library = await context.Libraries.Include(c => c.LibrariesGames).FirstAsync(l => l.UserId == userId);
            library.LibrariesGames.Add(new LibraryGame { GameId = gameId });
            await context.SaveChangesAsync();
            return $"Game '{game.Name}' purchased successfully.";
        }        
    }
}
