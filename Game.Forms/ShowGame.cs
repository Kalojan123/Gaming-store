using Gaming_store.Data;
using Gaming_store.Entities;
using GamingStore.Forms;
using Microsoft.EntityFrameworkCore;
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
        private GameContext context;
        public static Game CurrentGame { get; set; }
        public ShowGame(Game game)
        {
            InitializeComponent();
            Game = game;
             context = new GameContext();
            pictureBox1.Image = ImageHandeler.ByteArrayToImage(game.image);
        }        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser != null && LogInForm.CurrentUser.Username != "john123")
            {
                Library library = context.Libraries.Include(l => l.LibrariesGames).First(l => l.UserId == LogInForm.CurrentUser.Id);
                if(library.LibrariesGames.Any(lg => lg.GameId == Game.Id))
                {
                    MessageBox.Show("You already own this game.");
                    return;
                }
                CurrentGame = Game;
                GameInfo gameInfo = new GameInfo(CurrentGame);
                gameInfo.Show();                
            }
            else
            {
                MessageBox.Show("Please sign in or register to view game details.");
            }
        }
    }
}
