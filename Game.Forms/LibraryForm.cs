using Gaming_store.Data;
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
        private GameContext context;
        public LibraryForm()
        {
            InitializeComponent();
            context = new GameContext();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to your library, {LogInForm.CurrentUser.Username}!";
            if (LogInForm.CurrentUser.Library.LibrariesGames != null)
            {
                foreach (int gameId in LogInForm.CurrentUser.Library.LibrariesGames.Select(x => x.GameId))
                {
                    ShowLibrary showLibrary = new ShowLibrary(context.Games.First(g => g.Id == gameId));
                    flowLayoutPanel1.Controls.Add(showLibrary);
                }
                comboBox1.Items.AddRange(Enum.GetNames(typeof(Genres)));
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
                games = LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game).Where(g => g.Name.ToLower().StartsWith(textBox1.Text.ToLower())).ToList();
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
                games = LogInForm.CurrentUser.Library.LibrariesGames.Select(g => g.Game).Where(g => g.Genre == GenreHelper.GetGenresFromEnumName(comboBox1.SelectedItem.ToString())).ToList();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
