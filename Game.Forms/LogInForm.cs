using Gaming_store.Entities;
using Gaming_store.Enums;
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
    public partial class LogInForm : Form
    {
        private UserController userController;
        public static User CurrentUser { get; set; }
        public LogInForm()
        {
            InitializeComponent();
            userController = new UserController();
            CurrentUser = new User();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = await userController.Login(textBox1.Text, textBox2.Text);
            if (text == "Invalid username or password.")
            {
                MessageBox.Show(text, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                CurrentUser = await userController.GetUserByName(textBox1.Text);
                if (CurrentUser.Role == Roles.User)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Hiddenbuttons();
                    mainMenu.Show();
                    Hide();
                }
                else
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
