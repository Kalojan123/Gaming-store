using Gaming_store.Entities;
using Gaming_store.Forms;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentGame = game;
            GameInfo gameInfo = new GameInfo();
            gameInfo.ShowDialog();
            WishlistForm wishlistForm = new WishlistForm();
            wishlistForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
