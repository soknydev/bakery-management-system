namespace bakery_management_system.components
{
    partial class CartProductComponent
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
            panelComponent11 = new PanelComponent1();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonComponent11 = new ButtonComponent1();
            panelComponent11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelComponent11
            // 
            panelComponent11.BackColor = SystemColors.Control;
            panelComponent11.Controls.Add(buttonComponent11);
            panelComponent11.Controls.Add(label2);
            panelComponent11.Controls.Add(label1);
            panelComponent11.Controls.Add(pictureBox1);
            panelComponent11.Location = new Point(545, 78);
            panelComponent11.Name = "panelComponent11";
            panelComponent11.Size = new Size(278, 346);
            panelComponent11.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bakery1;
            pictureBox1.Location = new Point(47, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 101, 0);
            label1.Location = new Point(58, 11);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 1;
            label1.Text = "Bakey fresh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(126, 96, 191);
            label2.Location = new Point(89, 202);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 2;
            label2.Text = "12.99$";
            // 
            // buttonComponent11
            // 
            buttonComponent11.BackColor = Color.FromArgb(255, 101, 0);
            buttonComponent11.BackgroundColor = Color.FromArgb(255, 101, 0);
            buttonComponent11.BorderColor = Color.PaleVioletRed;
            buttonComponent11.BorderRadius = 8;
            buttonComponent11.BorderSize = 0;
            buttonComponent11.FlatAppearance.BorderSize = 0;
            buttonComponent11.FlatStyle = FlatStyle.Flat;
            buttonComponent11.Font = new Font("Segoe UI Semibold", 12F);
            buttonComponent11.ForeColor = Color.White;
            buttonComponent11.Location = new Point(31, 251);
            buttonComponent11.Name = "buttonComponent11";
            buttonComponent11.Padding = new Padding(15, 8, 15, 8);
            buttonComponent11.Size = new Size(215, 54);
            buttonComponent11.TabIndex = 3;
            buttonComponent11.Text = "Add to cart";
            buttonComponent11.TextColor = Color.White;
            buttonComponent11.UseVisualStyleBackColor = false;
            // 
            // CartProductComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 602);
            Controls.Add(panelComponent11);
            Name = "CartProductComponent";
            Text = "CartProductComponent";
            panelComponent11.ResumeLayout(false);
            panelComponent11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelComponent1 panelComponent11;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ButtonComponent1 buttonComponent11;
    }
}