using Gaming_store.Data;
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
    public partial class RemoveGameForm : Form
    {
        private GameContext context;
        private GameController controller;
        public RemoveGameForm()
        {
            InitializeComponent();
            context = new GameContext();
            controller = new GameController();
        }

        private void RemoveGameForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = context.Games.Select(g => g.Id).Min();
            numericUpDown1.Maximum = context.Games.Select(g => g.Id).Max();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await controller.RemoveGame((int)numericUpDown1.Value));
            numericUpDown1.Minimum = context.Games.Select(g => g.Id).Min();
            numericUpDown1.Maximum = context.Games.Select(g => g.Id).Max();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
