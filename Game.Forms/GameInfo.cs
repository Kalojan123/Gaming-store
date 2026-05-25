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
        public GameInfo()
        {
            InitializeComponent();
            wishlistController = new WishlistController();
        }

        private void GameInfo_Load(object sender, EventArgs e)
        {
            BackgroundImage = ImageHandeler.ByteArrayToImage(ShowGame.CurrentGame.image);
            label5.Text = ShowGame.CurrentGame.Name;
            label4.Text = $"{ShowGame.CurrentGame.Genre}";
            label6.Text = $"{ShowGame.CurrentGame.Price:C}";
            label7.Text = $"{ShowGame.CurrentGame.ReleaseDate}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
