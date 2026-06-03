using GamingStore.Forms.Properties;

namespace Gaming_store.Forms
{
    partial class ShowGameDiscount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(2, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Game has a discount";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackgroundImage = Resources.Red_X_svg;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(110, 2);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(18, 15);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ShowGameDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShowGameDiscount";
            Size = new Size(131, 112);
            Load += ShowGameDiscount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button6;
    }
}
