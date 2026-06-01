using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Enums;
using Gaming_store.Forms;
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
            if (LogInForm.CurrentUser.Cart.CartsGames != null)
            {
                foreach (int gameId in LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.GameId))
                {
                    ShowCart showCart = new ShowCart(context.Games.First(g => g.Id == gameId));
                    flowLayoutPanel1.Controls.Add(showCart);
                }
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
                games = LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game).Where(g => g.Name.Contains(textBox1.Text)).ToList();
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
                games = LogInForm.CurrentUser.Cart.CartsGames.Select(g => g.Game).Where(g => g.Genre == (Genres)comboBox1.SelectedItem).ToList();
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
    }
}
