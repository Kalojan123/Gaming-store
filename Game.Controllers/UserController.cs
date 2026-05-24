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
    public class UserController
    {
        private GameContext context;
        public UserController()
        {
            context = new GameContext();
        }
        public async Task<string> Register(string username, string password, string email, Roles role)
        {
            if (await context.Users.AnyAsync(u => u.Username == username))
            {
                return "Username already taken.";
            }
            if (await context.Users.AnyAsync(u => u.Email == email))
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
            await context.Users.AddAsync(newUser);
            await context.SaveChangesAsync();
            return "Registration successful.";
        }
        public async Task<string> Login(string username, string password)
        {
            User user = await context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
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
    }
}
