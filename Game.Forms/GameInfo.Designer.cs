namespace Gaming_store.Forms
{
    partial class GameInfo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label1.Location = new Point(334, 173);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 4;
            label1.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label2.Location = new Point(345, 283);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label3.Location = new Point(251, 395);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 6;
            label3.Text = "Release date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Orange;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label5.Location = new Point(431, 44);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 8;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Orange;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label4.Location = new Point(516, 173);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 9;
            label4.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Orange;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label6.Location = new Point(516, 283);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 10;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Orange;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            label7.Location = new Point(516, 395);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 11;
            label7.Text = "Release date";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            button1.Location = new Point(195, 495);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(198, 33);
            button1.TabIndex = 12;
            button1.Text = "Add to wishlist";
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
            button3.Location = new Point(644, 495);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 14;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            button2.Location = new Point(420, 495);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(198, 33);
            button2.TabIndex = 15;
            button2.Text = "Add to cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GameInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameInfo";
            Text = "GameInfo";
            Load += GameInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}