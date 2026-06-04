namespace Gaming_store.Forms
{
    partial class AdminForm
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
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(346, 152);
            button8.Name = "button8";
            button8.Size = new Size(109, 48);
            button8.TabIndex = 12;
            button8.Text = "Add game";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(326, 230);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 13;
            button1.Text = "Remove game";
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
            button2.Location = new Point(277, 311);
            button2.Name = "button2";
            button2.Size = new Size(247, 48);
            button2.TabIndex = 14;
            button2.Text = "Change price of a game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Orange;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label4.Location = new Point(306, 58);
            label4.Name = "label4";
            label4.Size = new Size(189, 23);
            label4.TabIndex = 26;
            label4.Text = "Hello, administrator!";
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(651, 381);
            button3.Name = "button3";
            button3.Size = new Size(109, 48);
            button3.TabIndex = 27;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button8);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button3;
    }
}