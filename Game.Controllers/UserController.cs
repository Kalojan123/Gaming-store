using Gaming_store;
using Gaming_store.Entities;
using Gaming_store.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Controllers
{
    public class UserController
    {
        private GameContext context;
        public UserController()
        {
            context = new GameContext();
        }
        public async Task<string> Register(string username, string password, string email, Roles role)
        {
            if (context.Users.Any(u => u.Username == username))
            {
                return "Username already taken.";
            }
            if (context.Users.Any(u => u.Email == email))
            {
                return "Email is already used.";
            }
            User newUser = new User
            {
                Username = username,
                Password = password,
                Email = email,
                Balance = 0,
                Role = role
            };
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
            return "Registration successful.";
        }
        public async Task<string> Login(string username, string password)
        {
            User user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                return "Invalid username or password.";
            }
            return $"Login successful. Welcome, {user.Username}!";
        }
        public async Task<string> UpdateBalance(int userId, decimal amount)
        {
            User user = await context.Users.FindAsync(userId);            
            if (amount <= 0 && user.Balance + amount <= 0)
            {
                return "Insufficient balance.";
            }
            user.Balance += amount;
            await context.SaveChangesAsync();
            return $"Balance updated. New balance: {user.Balance:C}.";
        }
        public async Task<string> AddGame(int userId, string gameName, Genres genre, decimal price, DateTime releaseDate)
        {
            User user = await context.Users.FindAsync(userId);            
            Game newGame = new Game
            {
                Name = gameName,
                Genre = genre,
                Price = price,
                ReleaseDate = releaseDate,
                UserId = userId
            };
            context.Games.Add(newGame);
            await context.SaveChangesAsync();
            return $"Game '{gameName}' added successfully.";
        }
    }
}
