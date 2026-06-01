using Gaming_store.Entities;
using Gaming_store.Forms;
using GamingStore.Controllers;
using GamingStore.Forms;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Gaming_store.Forms
{
    public partial class ShowWishlist : UserControl
    {
        private Game game;
        public static Game currentGame { get; set; }
        public ShowWishlist(Game Game)
        {
            InitializeComponent();
            game = new Game();
            game = Game;
            pictureBox1.Image = ImageHandeler.ByteArrayToImage(game.image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentGame = game;
            GameInfo gameInfo = new GameInfo(currentGame);
            gameInfo.ShowDialog();
            WishlistForm wishlistForm = new WishlistForm();
            wishlistForm.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            currentGame = game;
            CartController cart = new CartController();
            WishlistController wishlist = new WishlistController();
            if(LogInForm.CurrentUser.Cart.CartsGames.Any(wg => wg.GameId == currentGame.Id))
            {
                MessageBox.Show("This game is already in your cart.");
                return;
            }
            string result = await cart.AddToCart(LogInForm.CurrentUser.Id, currentGame.Id);
            MessageBox.Show(result);
            result = await wishlist.RemoveFromWishlist(LogInForm.CurrentUser.Id, currentGame.Id);
            MessageBox.Show(result);
        }

        private void ShowWishlist_Load(object sender, EventArgs e)
        {
            
        }
    }
}
