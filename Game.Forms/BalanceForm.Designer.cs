namespace Gaming_store.Forms
{
    partial class BalanceForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(173, 260);
            button1.Name = "button1";
            button1.Size = new Size(192, 33);
            button1.TabIndex = 2;
            button1.Text = "Update balance";
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
            button2.Location = new Point(428, 260);
            button2.Name = "button2";
            button2.Size = new Size(99, 33);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(135, 113);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 4;
            label1.Text = "Current balance:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(378, 113);
            label2.Name = "label2";
            label2.Size = new Size(188, 34);
            label2.TabIndex = 5;
            label2.Text = "balance";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BalanceForm";
            Text = "BalanceForm";
            Load += BalanceForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        public Label label2;
    }
}