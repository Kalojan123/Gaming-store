using Gaming_store.Data;
using Gaming_store.Entities;
using Gaming_store.Enums;
using GamingStore.Forms;
using Microsoft.IdentityModel.Tokens;

namespace Gaming_store.Forms
{
    public partial class MainMenu : Form
    {
        private GameContext context;
        public MainMenu()
        {
            InitializeComponent();
            context = new GameContext();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (context.Games != null)
            {
                foreach (Game game in context.Games)
                {
                    ShowGame showGame = new ShowGame(game);
                    flowLayoutPanel1.Controls.Add(showGame);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LogInForm.CurrentUser != null)
            {
                Hide();
                BalanceForm balanceForm = new BalanceForm();
                balanceForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please sign in or register to view your balance.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            if (LogInForm.CurrentUser != null)
            {
                if (LogInForm.CurrentUser.Library == null)
                {
                    MessageBox.Show("There are no games in the library!");
                    return;
                }
                LibraryForm libraryForm = new LibraryForm();
                libraryForm.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show("Please sign in or register to view your library.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = context.Games.Where(g => g.Name.Contains(textBox1.Text)).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that name.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowGame showGame = new ShowGame(game);
                    flowLayoutPanel1.Controls.Add(showGame);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (context.Games != null)
            {
                foreach (Game game in context.Games)
                {
                    ShowGame showGame = new ShowGame(game);
                    flowLayoutPanel1.Controls.Add(showGame);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != null)
            {
                List<Game> games = new List<Game>();
                games = context.Games.Where(g => g.Genre == (Genres)comboBox1.SelectedItem).ToList();
                if (games.Count == 0)
                {
                    MessageBox.Show("No games found with that genre.");
                    return;
                }
                foreach (Game game in games)
                {
                    ShowGame showGame = new ShowGame(game);
                    flowLayoutPanel1.Controls.Add(showGame);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (context.Games != null)
            {
                foreach (Game game in context.Games)
                {
                    ShowGame showGame = new ShowGame(game);
                    flowLayoutPanel1.Controls.Add(showGame);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {            
            if (LogInForm.CurrentUser != null)
            {
                if (LogInForm.CurrentUser.Wishlist == null)
                {
                    MessageBox.Show("There are no games in the wishlist!");
                    return;
                }
                WishlistForm wishlistForm = new WishlistForm();
                wishlistForm.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show("Please sign in or register to view your wishlist.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {            
            if (LogInForm.CurrentUser != null)
            {
                if (LogInForm.CurrentUser.Cart == null)
                {
                    MessageBox.Show("There are no games in the cart!");
                    return;
                }
                CartForm cartForm = new CartForm();
                cartForm.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show("Please sign in or register to view your cart.");
            }
        }    
        public void Hiddenbuttons()
        {
            button1.Visible = false;
            button2.Visible = false;
        }
        public void ShowDiscount(Game game)
        {
            ShowGameDiscount showGameDiscount = new ShowGameDiscount(game);
            showGameDiscount.Show(); 
        }
    }
}
