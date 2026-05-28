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

namespace Gaming_store.Forms
{
    public partial class UpdateBalanceForm : Form
    {
        private UserController userController;
        public UpdateBalanceForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void UpdateBalanceForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string result = await userController.UpdateBalance(LogInForm.CurrentUser.Id, numericUpDown1.Value);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();            
        }
    }
}
