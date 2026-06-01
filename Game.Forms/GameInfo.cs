using Gaming_store.Data;
using Gaming_store.Entities;
using GamingStore.Controllers;
using GamingStore.Forms;
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
        private GameContext context;
        private WishlistController wishlistController;
        private CartController cartController;
        private Game CurrentGame;
        public GameInfo(Game game)
        {
            InitializeComponent();
            context = new GameContext();
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
            if (await wishlistController.IsInWishlist(LogInForm.CurrentUser.Id,CurrentGame.Id) == false)
            {
                MessageBox.Show(await wishlistController.AddToWishlist(LogInForm.CurrentUser.Id, CurrentGame.Id));
                LogInForm.CurrentUser.Wishlist = context.Wishlists.First(w => w.UserId == LogInForm.CurrentUser.Id);
            }
            else
            {
                MessageBox.Show("You have already added this game to your wishlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser == null)
            {
                MessageBox.Show("Please sign in to add games to your cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            if(await cartController.IsInCart(LogInForm.CurrentUser.Id, CurrentGame.Id))
            {
                MessageBox.Show("You have already added this game to your cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(await cartController.AddToCart(LogInForm.CurrentUser.Id, CurrentGame.Id));
            LogInForm.CurrentUser.Cart = context.Carts.First(w => w.UserId == LogInForm.CurrentUser.Id);
            await wishlistController.RemoveFromWishlist(LogInForm.CurrentUser.Id, CurrentGame.Id);
        }
    }
}
