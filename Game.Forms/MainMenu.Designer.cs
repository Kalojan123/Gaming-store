namespace Gaming_store.Forms
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Maroon;
            flowLayoutPanel1.Location = new Point(-1, 51);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(734, 551);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(673, 3);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 1;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(792, 3);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 2;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(393, 3);
            label1.Name = "label1";
            label1.Size = new Size(129, 45);
            label1.TabIndex = 3;
            label1.Text = "All games ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(554, 3);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 44);
            button3.TabIndex = 4;
            button3.Text = "Balance";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(238, 3);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 44);
            button4.TabIndex = 5;
            button4.Text = "Library";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(739, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(739, 112);
            label2.Name = "label2";
            label2.Size = new Size(169, 66);
            label2.TabIndex = 4;
            label2.Text = "Filter by genre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(775, 320);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackgroundImage = GamingStore.Forms.Properties.Resources.Magnifying_glass_icon_svg;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(738, 320);
            button5.Name = "button5";
            button5.Size = new Size(30, 29);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = GamingStore.Forms.Properties.Resources.Red_X_svg;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(880, 293);
            button6.Name = "button6";
            button6.Size = new Size(21, 20);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = GamingStore.Forms.Properties.Resources.Red_X_svg;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(880, 181);
            button7.Name = "button7";
            button7.Size = new Size(21, 20);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(0, 3);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(113, 44);
            button8.TabIndex = 11;
            button8.Text = "Wishlist";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatAppearance.MouseDownBackColor = Color.White;
            button9.FlatAppearance.MouseOverBackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button9.Location = new Point(119, 3);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(113, 44);
            button9.TabIndex = 12;
            button9.Text = "Cart";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DimGray;
            button10.FlatAppearance.MouseDownBackColor = Color.White;
            button10.FlatAppearance.MouseOverBackColor = Color.White;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button10.Location = new Point(758, 449);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(113, 44);
            button10.TabIndex = 13;
            button10.Text = "Sign off";
            button10.UseVisualStyleBackColor = false;
            button10.Visible = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DimGray;
            button11.FlatAppearance.MouseDownBackColor = Color.White;
            button11.FlatAppearance.MouseOverBackColor = Color.White;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button11.Location = new Point(758, 517);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(113, 44);
            button11.TabIndex = 14;
            button11.Text = "Exit";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(673, 2);
            label3.Name = "label3";
            label3.Size = new Size(236, 45);
            label3.TabIndex = 15;
            label3.Text = "Someone's library";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        public Button button2;
        public Button button1;
        public Button button10;
        public Button button11;
        public Label label3;
    }
}
