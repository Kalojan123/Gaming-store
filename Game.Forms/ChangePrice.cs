using Gaming_store.Data;
using GamingStore.Controllers;
using Microsoft.EntityFrameworkCore;
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
    public partial class ChangePrice : Form
    {
        private GameContext context;
        private GameController controller;
        public ChangePrice()
        {
            InitializeComponent();
            context = new GameContext();
            controller = new GameController();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = context.Games.Count() - 1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < context.Games.Where(g => g.Id == (int)numericUpDown1.Value).First().Price)
            {
                MessageBox.Show(await controller.UpdatePrice((int)numericUpDown1.Value, numericUpDown1.Value));
                MainMenu menu = new MainMenu();
                menu.ShowDiscount(context.Games.Where(g => g.Id == (int)numericUpDown1.Value).First());
                return;
            }   
            MessageBox.Show(await controller.UpdatePrice((int)numericUpDown1.Value, numericUpDown1.Value));
        }
    }
}
