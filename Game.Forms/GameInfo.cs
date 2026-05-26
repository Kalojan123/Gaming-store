using Gaming_store.Entities;
using GamingStore.Controllers;
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
    public partial class GameInfo : Form
    {
        private WishlistController wishlistController;
        private CartController cartController;
        private Game CurrentGame;
        public GameInfo(Game game)
        {
            InitializeComponent();
            wishlistController = new WishlistController();
            cartController = new CartController();
            CurrentGame = new Game();
            CurrentGame = game;
        }

        private void GameInfo_Load(object sender, EventArgs e)
        {
            BackgroundImage = ImageHandeler.ByteArrayToImage(CurrentGame.image);
            label5.Text = CurrentGame.Name;
            label4.Text = $"{CurrentGame.Genre}";
            label6.Text = $"{CurrentGame.Price:C}";
            label7.Text = $"{CurrentGame.ReleaseDate}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser == null)
            {
                MessageBox.Show("Please sign in to add games to your wishlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(await wishlistController.AddToWishlist(LogInForm.CurrentUser.Id, CurrentGame.Id));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser == null)
            {
                MessageBox.Show("Please sign in to add games to your cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(await cartController.AddToCart(LogInForm.CurrentUser.Id, CurrentGame.Id));
        }
    }
}
