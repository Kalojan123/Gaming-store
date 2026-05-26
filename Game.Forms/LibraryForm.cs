using Gaming_store.Entities;
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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your library, {LogInForm.CurrentUser.Username}!";
            if (LogInForm.CurrentUser.Library.LibrariesGames != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Library.LibrariesGames.Select(x => x.Game))
                {
                    ShowLibrary showLibrary = new ShowLibrary();
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
            }
            else
            {
                MessageBox.Show("Your library is empty. Purchase some games to see them here.");
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
