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
    public partial class WishlistForm : Form
    {
        public WishlistForm()
        {
            InitializeComponent();
        }

        private void WishlistForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your wishlist, {LogInForm.CurrentUser.Username}!";
            if (LogInForm.CurrentUser.Wishlist.WishlistsGames != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(x => x.Game))
                {
                    ShowWishlist showWishlist = new ShowWishlist(game);
                    flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
            else
            {
                MessageBox.Show("Your library is empty. Purchase some games to see them here.");
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
        }
    }
}
