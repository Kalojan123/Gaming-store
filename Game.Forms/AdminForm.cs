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

namespace Gaming_store.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GameInfo2 gameInfo2 = new GameInfo2();
            gameInfo2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveGameForm removeGameForm = new RemoveGameForm();
            removeGameForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePriceForm changePriceForm = new ChangePriceForm();
            changePriceForm.ShowDialog();
        }
    }
}
