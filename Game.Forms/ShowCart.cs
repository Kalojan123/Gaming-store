using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Forms;
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
    public partial class ShowCart : UserControl
    {
        private Game game;
        private GameContext context;
        public static Game CurrentGame { get; set; }
        public ShowCart(Game Game)
        {
            InitializeComponent();
            game = new Game();
            context = new GameContext();
            game = Game;
            pictureBox1.Image = ImageHandeler.ByteArrayToImage(game.image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CurrentGame = game;
            GameInfo gameInfo = new GameInfo(CurrentGame);
            gameInfo.ShowDialog();
            CartForm cartForm = new CartForm();
            cartForm.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CurrentGame = game;
            CartController cart = new CartController();
            LibraryController library = new LibraryController();
            string output = await library.AddToLibrary(LogInForm.CurrentUser.Id, CurrentGame.Id);
            if(output == "Insufficient balance.")
            {
                MessageBox.Show(output);
                return;
            }
            MessageBox.Show(output);
            string output2 = await cart.RemoveFromCart(LogInForm.CurrentUser.Id, CurrentGame.Id);           
            MessageBox.Show(output2);
            LogInForm.CurrentUser.Library = context.Libraries.First(l => l.UserId == LogInForm.CurrentUser.Id);
        }
    }
}
