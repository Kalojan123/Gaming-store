using Gaming_store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingStore.Forms
{
    public partial class ShowGameDiscount : UserControl
    {
        public ShowGameDiscount(Game game)
        {
            InitializeComponent();
            label1.Text = $"{game.Name} is on sale for {game.Price}!";
        }

        private void ShowGameDiscount_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
