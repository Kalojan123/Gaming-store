using GamingStore.Forms.Properties;

namespace Gaming_store.Forms
{
    partial class LibraryForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button8 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Maroon;
            flowLayoutPanel1.Location = new Point(1, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(609, 400);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(293, 4);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 4;
            label1.Text = "Someone's library";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.BackgroundImage = Resources.Red_X_svg;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(758, 204);
            button7.Name = "button7";
            button7.Size = new Size(21, 20);
            button7.TabIndex = 16;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Resources.Red_X_svg;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(758, 316);
            button6.Name = "button6";
            button6.Size = new Size(21, 20);
            button6.TabIndex = 15;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Resources.Magnifying_glass_icon_svg;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(616, 343);
            button5.Name = "button5";
            button5.Size = new Size(30, 29);
            button5.TabIndex = 14;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(653, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.BackColor = Color.Orange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(617, 135);
            label2.Name = "label2";
            label2.Size = new Size(169, 66);
            label2.TabIndex = 11;
            label2.Text = "Filter by genre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(617, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(643, 394);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(113, 44);
            button8.TabIndex = 17;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 451);
            ControlBox = false;
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "LibraryForm";
            Text = "LibraryForm";
            Load += LibraryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button8;
    }
}