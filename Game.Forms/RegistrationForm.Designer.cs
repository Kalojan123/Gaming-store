namespace Gaming_store.Forms
{
    partial class RegistrationForm
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.CheckedBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(445, 365);
            button2.Name = "button2";
            button2.Size = new Size(169, 67);
            button2.TabIndex = 27;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button1.Location = new Point(187, 365);
            button1.Name = "button1";
            button1.Size = new Size(169, 67);
            button1.TabIndex = 26;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Orange;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label4.Location = new Point(327, 63);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 25;
            label4.Text = "Registration";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(454, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 24;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(222, 291);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 21;
            label3.Text = "Repeat password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label2.Location = new Point(305, 230);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 20;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label1.Location = new Point(256, 114);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 19;
            label1.Text = "Email address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label5.Location = new Point(298, 170);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 28;
            label5.Text = "Username:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(454, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 29;
            textBox4.UseSystemPasswordChar = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 451);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox4;
    }
}