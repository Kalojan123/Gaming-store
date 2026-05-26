using Gaming_store.Forms;
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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            label2.Text = $"{LogInForm.CurrentUser.Balance:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBalanceForm updateBalanceForm = new UpdateBalanceForm();
            updateBalanceForm.ShowDialog();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
