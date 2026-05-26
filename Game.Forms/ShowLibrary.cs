using Gaming_store.Entities;
using Gaming_store.Forms;
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
    public partial class ShowLibrary : UserControl
    {        
        private Game game;
        public static Game CurrentGame { get; set; } 
        public ShowLibrary(Game Game)
        {
            InitializeComponent();
            game = new Game();
            game = Game;
        }        

        private void ShowLibrary_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {           
            CurrentGame = game;
            GameInfo gameInfo = new GameInfo(CurrentGame);
            gameInfo.ShowDialog();
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Hide();
        }
    }
}
