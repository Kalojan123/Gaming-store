using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Forms;
using GamingStore.Controllers;
using GamingStore.Forms;
using Microsoft.EntityFrameworkCore;
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
        private GameContext context;
        public Game currentGame { get; set; }
        public ShowWishlist(Game Game)
        {
            InitializeComponent();
            game = new Game();
            game = Game;
            context = new GameContext();
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
            await wishlist.RemoveFromWishlist(LogInForm.CurrentUser.Id, currentGame.Id);            
            LogInForm.CurrentUser = context.Users.Include(u => u.Wishlist).ThenInclude(u => u.WishlistsGames).ThenInclude(u => u.Game).Include(u => u.Cart).ThenInclude(u => u.CartsGames).ThenInclude(u => u.Game).Include(u => u.Library).ThenInclude(u => u.LibrariesGames).ThenInclude(u => u.Game).First(u => u.Username == LogInForm.CurrentUser.Username);
            WishlistForm wishlistForm = new WishlistForm();
            wishlistForm.flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Wishlist != null)
            {
                foreach (Game game2 in LogInForm.CurrentUser.Wishlist.WishlistsGames.Select(g => g.Game))
                {
                    ShowWishlist showWishlist = new ShowWishlist(game2);
                    wishlistForm.flowLayoutPanel1.Controls.Add(showWishlist);
                }
            }
        }

        private void ShowWishlist_Load(object sender, EventArgs e)
        {
            
        }
    }
}
