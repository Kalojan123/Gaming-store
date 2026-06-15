using Gaming_store.Data;
using Gaming_store.Enums;
using GamingStore.Controllers;
using GamingStore.Forms;
using GamingStore.Forms.Properties;
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
    public partial class GameInfo2 : Form
    {
        private GameController gameController;
        public GameInfo2()
        {
            InitializeComponent();
            gameController = new GameController();
        }
        private void GameInfo2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Genres)));
        }
        private bool ImagesAreEqual(Image img1, Image img2)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                return false;

            Bitmap bmp1 = new Bitmap(img1);
            Bitmap bmp2 = new Bitmap(img2);

            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        return false;
                }
            }

            return true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !ImagesAreEqual(pictureBox1.Image,Resources.Rk8hwA80) && numericUpDown1.Value != (decimal)0.01)
            {
                MessageBox.Show(await gameController.AddGame(textBox1.Text, Enum.Parse<Genres>(comboBox1.Text), numericUpDown1.Value, ImageHandeler.ImageToByteArray((Bitmap)pictureBox1.Image),DateOnly.FromDateTime(dateTimePicker1.Value.Date)));
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid game name or put a valid picture or set a price!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
