using Gaming_store.Entities;
using Gaming_store.Enums;
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

namespace Gaming_store.Forms
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
                    ShowLibrary showLibrary = new ShowLibrary(game);
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

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game).Where(g => g.Name.Contains(textBox1.Text)).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that name.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowLibrary showLibrary = new ShowLibrary(game);
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Library != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game))
                {
                    ShowLibrary showLibrary = new ShowLibrary(game);
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game).Where(g => g.Genre == (Genres)comboBox1.SelectedItem).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that genre.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowLibrary showLibrary = new ShowLibrary(game);
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (LogInForm.CurrentUser.Library != null)
            {
                foreach (Game game in LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game))
                {
                    ShowLibrary showLibrary = new ShowLibrary(game);
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
            }
        }
    }
}
