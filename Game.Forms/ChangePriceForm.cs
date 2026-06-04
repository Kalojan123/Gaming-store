using Gaming_store.Data;
using Gaming_store.Forms;
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

namespace GamingStore.Forms
{
    public partial class ChangePriceForm : Form
    {
        private GameContext context;
        private GameController controller;
        public static string GameName { get; set; }
        public static decimal GamePrice { get; set; }
        public static decimal newGamePrice { get; set; }
        public ChangePriceForm()
        {
            InitializeComponent();
            context = new GameContext();
            controller = new GameController();
            GameName = "";
            GamePrice = 0;
            newGamePrice = 0;
            GameName = context.Games.First(g => g.Id == ((int)numericUpDown1.Value) - 1).Name;
            GamePrice = context.Games.First(g => g.Id == ((int)numericUpDown1.Value) - 1).Price;            
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = context.Games.Select(g => g.Id).Min();
            numericUpDown1.Maximum = context.Games.Select(g => g.Id).Max();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal price = context.Games.First(g => g.Id == ((int)numericUpDown1.Value - 1)).Price;
            if (((decimal)numericUpDown2.Value) < price)
            {
                DialogResult result = DialogResult.Yes;                
            }
            MessageBox.Show(await controller.UpdatePrice((int)numericUpDown1.Value, (decimal)numericUpDown2.Value));
            newGamePrice = (decimal)numericUpDown2.Value;
            numericUpDown1.Minimum = context.Games.Select(g => g.Id).Min();
            numericUpDown1.Maximum = context.Games.Select(g => g.Id).Max();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
