using Gaming_store.Entities;
using Gaming_store.Enums;
using GamingStore.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_store.Forms
{
    public partial class RegistrationForm : Form
    {
        private UserController userController;
        private WishlistController wishlistController;
        private CartController cartController;
        private LibraryController libraryController;
        public RegistrationForm()
        {
            InitializeComponent();
            userController = new UserController();
            wishlistController = new WishlistController();
            cartController = new CartController();
            libraryController = new LibraryController();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = await userController.Register(textBox2.Text, textBox3.Text, textBox1.Text);
            if (result == "Registration successful.")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User user = await userController.GetUserByName(textBox2.Text);
                await wishlistController.CreateWishlist(user.Id);
                await cartController.CreateCart(user.Id);
                await libraryController.CreateLibrary(user.Id);
                this.Hide();
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
