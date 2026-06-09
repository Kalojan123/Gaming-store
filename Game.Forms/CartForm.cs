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
    public partial class CartForm : Form
    {
        private GameContext context;
        public CartForm()
        {
            InitializeComponent();
            context = new GameContext();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your cart, {LogInForm.CurrentUser.Username}!";
            label3.Text = $"Total price: ${LogInForm.CurrentUser.Cart.CartsGames.Sum(g => g.Game.Price)}";
            if (LogInForm.CurrentUser.Cart.CartsGames != null)
            {
                foreach (int gameId in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.GameId))
                {
                    ShowCart showCart = new ShowCart(context.Games.First(g => g.Id == gameId));
                    flowLayoutPanel1.Controls.Add(showCart);
                }
                comboBox1.Items.AddRange(Enum.GetNames(typeof(Genres)));
            }
            else
            {
                MessageBox.Show("Your cart is empty. Add some games to see them here.");
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
                games = LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game).Where(g => g.Name.ToLower().StartsWith(textBox1.Text.ToLower())).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that name.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowCart showCart = new ShowCart(game);
                    flowLayoutPanel1.Controls.Add(showCart);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Cart != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game))
                {
                    ShowCart showCart = new ShowCart(game);
                    flowLayoutPanel1.Controls.Add(showCart);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game).Where(g => g.Genre == GenreHelper.GetGenresFromEnumName(comboBox1.SelectedItem.ToString())).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that genre.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowCart showCart = new ShowCart(game);
                    flowLayoutPanel1.Controls.Add(showCart);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Cart != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game))
                {
                    ShowCart showCart = new ShowCart(game);
                    flowLayoutPanel1.Controls.Add(showCart);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach (Game game in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game))
            {
                CartController cart = new CartController();
                LibraryController library = new LibraryController();
                string output = await library.AddToLibrary(LogInForm.CurrentUser.Id, game.Id);
                if (output == $"Insufficient balance for {game.Name}.")
                {
                    MessageBox.Show(output);
                    return;
                }
                else if (output == $"Game {game.Name} is already in library.")
                {
                    MessageBox.Show(output);
                    continue;
                }
                MessageBox.Show(output);
                Wishlist wishlist = await context.Wishlists.Include(w => w.WishlistsGames).FirstAsync(w => w.UserId == LogInForm.CurrentUser.Id);
                if (wishlist.WishlistsGames.Any(wg => wg.GameId == game.Id))
                {
                    WishlistController wishlistController = new WishlistController();
                    await wishlistController.RemoveFromWishlist(LogInForm.CurrentUser.Id, game.Id);
                }
                string output2 = await cart.RemoveFromCart(LogInForm.CurrentUser.Id, game.Id);
                LogInForm.CurrentUser = context.Users.Include(u => u.Wishlist).ThenInclude(u => u.WishlistsGames).ThenInclude(u => u.Game).Include(u => u.Cart).ThenInclude(u => u.CartsGames).ThenInclude(u => u.Game).Include(u => u.Library).ThenInclude(u => u.LibrariesGames).ThenInclude(u => u.Game).First(u => u.Username == LogInForm.CurrentUser.Username);
            }
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Cart != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game))
                {
                    ShowCart showCart = new ShowCart(game);
                    flowLayoutPanel1.Controls.Add(showCart);
                }
            }
        }
    }
}
