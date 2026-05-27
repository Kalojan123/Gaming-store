using Gaming_store.Entities;
using Gaming_store.Enums;
using GamingStore.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Helpers;

namespace Test1.Services
{
    public class AuthServiceTests
    {
        [Test]
        public async Task Login_User_1()
        {
            var context = TestDbFactory.CreateContext();

            context.Users.Add(new User
            { 
                Username = "Ivan",
                Password = "123",
                Email = "Ivan@gmail.com",
                Balance = 0,
                Role = Roles.User
            });
            await context.SaveChangesAsync();
            UserController userController = new UserController(context);
            string result = await userController.Login("Ivan", "123");
            Assert.AreNotEqual("Invalid username or password.", result);
        }
        [Test]
        public async Task LogIn_User_2()
        {
            var context = TestDbFactory.CreateContext();
            UserController controller = new UserController(context);
            string result = await controller.Login("Petyo", "11122");
            Assert.AreEqual("Invalid username or password.", result);
        }
        [Test]
        public async Task GetUserByName_Test()
        {
            var context = TestDbFactory.CreateContext();
            context.Users.Add(new User
            {
                Username = "Ivan",
                Password = "123",
                Email = "Ivan@gmail.com",
                Balance = 0,
                Role = Roles.User
            });
            await context.SaveChangesAsync();
            UserController userController = new UserController(context);
            User? user = await userController.GetUserByName("Ivan");
            Assert.IsNotNull(user);
            Assert.AreEqual("Ivan",user.Username);
        }
        [Test]
        public async Task Register_Test()
        {
            var context = TestDbFactory.CreateContext();
            UserController controller = new UserController(context);
            string result = await controller.Register("Ivan","123","Ivan@gmail.com");            
            Assert.AreEqual("Registration successful.", result);
        }
        [Test]
        public async Task Register_Test_2()
        {
            var context = TestDbFactory.CreateContext();
            context.Users.Add(new User
            {
                Username = "Ivan",
                Password = "123",
                Email = "Ivan@gmail.com",
                Balance = 0,
                Role = Roles.User
            });
            await context.SaveChangesAsync();
            UserController controller = new UserController(context);
            string result = await controller.Register("Ivan", "12314", "IvanP@gmail.com");
            Assert.AreEqual("Username is already taken.", result);
        }
        [Test]
        public async Task Register_Test_3()
        {
            var context = TestDbFactory.CreateContext();
            context.Users.Add(new User
            {
                Username = "Ivan",
                Password = "123",
                Email = "Ivan@gmail.com",
                Balance = 0,
                Role = Roles.User
            });
            await context.SaveChangesAsync();
            UserController controller = new UserController(context);
            string result = await controller.Register("Pesho", "12314", "Ivan@gmail.com");
            Assert.AreEqual("Email is already used.", result);
        }
        [Test]
        public async Task UpdateBalance_Test()
        {
            var context = TestDbFactory.CreateContext();
            context.Users.Add(new User
            {
                Username = "Ivan",
                Password = "123",
                Email = "Ivan@gmail.com",
                Balance = 0,
                Role = Roles.User
            });
            await context.SaveChangesAsync();
            UserController controller = new UserController(context);
            string result = await controller.UpdateBalance(1,100.00m);
            Assert.AreEqual($"Balance updated.", result);
            Assert.AreEqual(100.00m,context.Users.First(u => u.Id == 1).Balance);
        }
    }
}
