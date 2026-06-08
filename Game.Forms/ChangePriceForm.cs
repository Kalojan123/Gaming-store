using Gaming_store.Data;
using Gaming_store.Entities;
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
        public ChangePriceForm()
        {
            InitializeComponent();
            context = new GameContext();
            controller = new GameController();
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {
            if (!context.Games.Any())
            {
                return;
            }
            comboBox1.Items.AddRange(context.Games.Select(g => g.Name).ToArray());
            comboBox1.SelectedIndex = 0;
            numericUpDown2.Value = context.Games.First(g => g.Name == comboBox1.Text).Price;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal price = context.Games.First(g => g.Name == comboBox1.Text).Price;
            if (price == (decimal)numericUpDown2.Value)
            {
                MessageBox.Show("The new price must be different from the old price.");
                return;
            }
            PriceChangeGame game;
            if (context.PriceChangeGames.Any(p => p.GameName == comboBox1.Text))
            {
                game = context.PriceChangeGames.First(p => p.GameName == comboBox1.Text);
                game.OldPrice = game.NewPrice;
                game.NewPrice = (decimal)numericUpDown2.Value;
                context.PriceChangeGames.Update(game);
                context.SaveChanges();
            }
            else
            {
                game = new PriceChangeGame
                {
                    GameName = comboBox1.Text,
                    NewPrice = (decimal)numericUpDown2.Value,
                    OldPrice = price
                };
                context.PriceChangeGames.Add(game);
                context.SaveChanges();
            }
            MessageBox.Show(await controller.UpdatePrice(context.Games.First(g => g.Name == comboBox1.Text).Id, (decimal)numericUpDown2.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Game selectedGame = context.Games.FirstOrDefault(g => g.Name == comboBox1.Text);
            if (selectedGame != null)
                numericUpDown2.Value = selectedGame.Price;
            else
                numericUpDown2.Value = 0.01m;
        }
    }
}
