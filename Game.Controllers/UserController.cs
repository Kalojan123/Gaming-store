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
        public async Task<User> GetUserByName(string username)
        {
            return await context.Users.FirstAsync(u => u.Username == username); 
        }
        public async Task<string> Register(string username, string password, string email)
        {
            if (await context.Users.AnyAsync(u => u.Username == username))
            {
                return "Username already taken.";
            }
            if (await context.Users.AnyAsync(u => u.Email == email))
            {
                return "Email is already used.";
            }
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.Email = email;
            newUser.Balance = 0;
            newUser.Role = Roles.User;
            newUser.WishlistId = new Wishlist()
            {
                UserId = newUser.Id
            }.Id;            
            newUser.CartId = new Cart()
            {
                UserId = newUser.Id
            }.Id;
            newUser.LibraryId = new Library()
            {
                UserId = newUser.Id
            }.Id;
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
            user.Balance += amount;
            await context.SaveChangesAsync();
            return $"Balance updated.";
        }       
    }
}
