using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Enums;
using GamingStore.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_store.Forms
{
    public partial class LogInForm : Form
    {
        private GameContext context;
        private UserController userController;
        public static User CurrentUser { get; set; }
        public LogInForm()
        {
            InitializeComponent();
            context = new GameContext();
            userController = new UserController();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = await userController.Login(textBox1.Text, textBox2.Text);
            if (text == "Invalid username or password.")
            {
                MessageBox.Show(text, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentUser = new User();
                CurrentUser = context.Users.Include(u => u.Wishlist).ThenInclude(u => u.WishlistsGames).ThenInclude(u => u.Game).Include(u => u.Cart).ThenInclude(u => u.CartsGames).ThenInclude(u => u.Game).Include(u => u.Library).ThenInclude(u => u.LibrariesGames).ThenInclude(u => u.Game).First(u => u.Username == textBox1.Text);
                if (CurrentUser.Role == Roles.User)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.button1.Visible = false;
                    mainMenu.button2.Visible = false;
                    mainMenu.button10.Visible = true;
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        public static void UpdateBalance(decimal balance)
        {
            CurrentUser.Balance += balance;
        }
    }
}
