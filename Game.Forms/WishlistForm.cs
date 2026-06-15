using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Enums;
using Gaming_store.Forms;
using GamingStore.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_store.Forms
{
    public partial class WishlistForm : Form
    {
        private GameContext context;
        public WishlistForm()
        {
            context = new GameContext();
            InitializeComponent();
        }

        private void WishlistForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your wishlist, {LogInForm.CurrentUser.Username}!";
            if (LogInForm.CurrentUser.Wishlist.WishlistsGames != null)
            {
                foreach (int gameId in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(x => x.GameId))
                {
                    ShowWishlist showWishlist = new ShowWishlist(context.Games.First(g => g.Id == gameId));
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
                comboBox1.Items.AddRange(Enum.GetNames(typeof(Genres)));
            }
            else
            {
                MessageBox.Show("Your wishlist is empty. Add some games to see them here.");
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game).Where(g => g.Name.ToLower().StartsWith(textBox1.Text.ToLower())).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that name.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowWishlist showWishlist = new ShowWishlist(game);
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Wishlist != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game))
                {
                    ShowWishlist showWishlist = new ShowWishlist(game);
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Game> games = new List<Game>();
            games = LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game).Where(g => g.Genre == Enum.Parse<Genres>(comboBox1.SelectedItem.ToString())).ToList();
            if (games.Count == 0)
            {
                MessageBox.Show("No games found with that genre.");
                return;
            }
            foreach (Game game in games)
            {
                ShowWishlist showWishlist = new ShowWishlist(game);
                flowLayoutPanel1.Controls.Add(showWishlist);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Wishlist != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game))
                {
                    ShowWishlist showWishlist = new ShowWishlist(game);
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach (Game game in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game))
            {
                CartController cart = new CartController();
                WishlistController wishlist = new WishlistController();
                if (LogInForm.CurrentUser.Cart.CartsGames.Any(wg => wg.GameId == game.Id))
                {
                    MessageBox.Show($"Game {game.Name} is already in your cart.");
                    continue;
                }
                await cart.AddToCart(LogInForm.CurrentUser.Id, game.Id);
                await wishlist.RemoveFromWishlist(LogInForm.CurrentUser.Id, game.Id);
                LogInForm.CurrentUser = context.Users.Include(u => u.Wishlist).ThenInclude(u => u.WishlistsGames).ThenInclude(u => u.Game).Include(u => u.Cart).ThenInclude(u => u.CartsGames).ThenInclude(u => u.Game).Include(u => u.Library).ThenInclude(u => u.LibrariesGames).ThenInclude(u => u.Game).First(u => u.Username == LogInForm.CurrentUser.Username);
            }
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Wishlist != null)
            {
                foreach (Game game2 in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game))
                {
                    ShowWishlist showWishlist = new ShowWishlist(game2);
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
        }
    }
}
