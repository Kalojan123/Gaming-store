namespace GamingStore.Forms
{
    partial class ChangePriceForm
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
            button3 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            button3.Location = new Point(435, 351);
            button3.Name = "button3";
            button3.Size = new Size(96, 57);
            button3.TabIndex = 26;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(255, 351);
            button1.Name = "button1";
            button1.Size = new Size(99, 57);
            button1.TabIndex = 25;
            button1.Text = "Change price";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(415, 158);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 24;
            // 
            // label2
            // 
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(255, 142);
            label2.Name = "label2";
            label2.Size = new Size(113, 49);
            label2.TabIndex = 23;
            label2.Text = "Choose game id ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(344, 42);
            label1.Name = "label1";
            label1.Size = new Size(113, 50);
            label1.TabIndex = 22;
            label1.Text = "Change price";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(415, 239);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 23);
            numericUpDown2.TabIndex = 27;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(255, 211);
            label3.Name = "label3";
            label3.Size = new Size(113, 71);
            label3.TabIndex = 28;
            label3.Text = "Choose new game price ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseWaitCursor = true;
            // 
            // ChangePriceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePriceForm";
            Text = "ChangePriceForm";
            Load += ChangePriceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        public Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private Label label3;
    }
}