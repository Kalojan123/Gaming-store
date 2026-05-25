using Gaming_store.Data;
using Gaming_store.Entities;

namespace Gaming_store.Forms
{
    public partial class MainMenu : Form
    {
        private GameContext context;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Game game in context.Games)
            {
                ShowGame showGame = new ShowGame(game);
                flowLayoutPanel1.Controls.Add(showGame);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }
    }
}
