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
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {
            if (!context.Games.Any())
            {
                return;
            }
            comboBox1.Items.AddRange(context.Games.Select(g => g.Name).ToArray());
            comboBox1.SelectedIndex = 0;
            GameName = comboBox1.Text;
            GamePrice = context.Games.First(g => g.Name == comboBox1.Text).Price;
        }

        private async void button1_Click(object sender, EventArgs e)
        {            
            decimal price = context.Games.First(g => g.Name == comboBox1.Text).Price;
            if (((decimal)numericUpDown2.Value) < price)
            {
                DialogResult result = DialogResult.Yes;                
            }
            MessageBox.Show(await controller.UpdatePrice(context.Games.First(g => g.Name == comboBox1.Text).Id, (decimal)numericUpDown2.Value));
            newGamePrice = (decimal)numericUpDown2.Value;
            comboBox1.Items.AddRange(context.Games.Select(g => g.Name).ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
