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
            RemoveGameForm_Load(this, EventArgs.Empty);
        }

        private void RemoveGameForm_Load(object sender, EventArgs e)
        {
            if (!context.Games.Any())
            {
                return;
            }
            comboBox1.Items.AddRange(context.Games.Select(g => g.Name).ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (HandleEmptyCombobox())
            {
                return;
            }
            MessageBox.Show(await controller.RemoveGame(context.Games.First(g => g.Name == comboBox1.Text).Id));
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(context.Games.Select(g => g.Name).ToArray());
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                HandleEmptyCombobox();
            }
        }
        private bool HandleEmptyCombobox()
        {
            if (!context.Games.Any())
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("There are no games yet!");
                comboBox1.SelectedIndex = 0;
                return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
