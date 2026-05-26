namespace Gaming_store.Forms
{
    partial class GameInfo2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label3.Location = new Point(56, 265);
            label3.Name = "label3";
            label3.Size = new Size(120, 24);
            label3.TabIndex = 14;
            label3.Text = "Release date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label2.Location = new Point(121, 209);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 13;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label1.Location = new Point(114, 153);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 12;
            label1.Text = "Genre";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            button1.Location = new Point(233, 367);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 19;
            button1.Text = "Add game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            button3.Location = new Point(451, 367);
            button3.Name = "button3";
            button3.Size = new Size(66, 34);
            button3.TabIndex = 20;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(261, 210);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 22;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(261, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.Value = new DateTime(2026, 5, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Orange;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label4.Location = new Point(114, 97);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 24;
            label4.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GamingStore.Forms.Properties.Resources.Rk8hwA80;
            pictureBox1.Location = new Point(557, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GameInfo2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GameInfo2";
            Text = "GameInfo2";
            Load += GameInfo2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}