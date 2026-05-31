using Gaming_store.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
            label2.Text = $"{LogInForm.CurrentUser.Balance:C}";
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBalanceForm updateBalanceForm = new UpdateBalanceForm();
            updateBalanceForm.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Hide();
        }
    }
}
