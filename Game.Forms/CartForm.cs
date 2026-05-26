using Gaming_store.Entities;
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
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your cart, {LogInForm.CurrentUser.Username}!";
            if (LogInForm.CurrentUser.Cart.CartsGames != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Cart.CartsGames.Select(x => x.Game))
                {
                    ShowCart showCart = new ShowCart(game);
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
    }
}
