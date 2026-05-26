using Gaming_store.Data;
using Gaming_store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_store.Forms
{
    public partial class ShowGame : UserControl
    {
        private Game Game;
        public static Game CurrentGame { get; set; }
        public ShowGame(Game game)
        {
            InitializeComponent();
            Game = game;
            pictureBox1.Image = ImageHandeler.ByteArrayToImage(game.image);
        }        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser != null)
            {
                CurrentGame = Game;
                GameInfo gameInfo = new GameInfo(CurrentGame);
                gameInfo.ShowDialog();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Hide();
            }
            else
            {
                MessageBox.Show("Please sign in or register to view game details.");
            }
        }
    }
}
