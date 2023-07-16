namespace BandB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuPanel = new Panel();
            btnHistory = new Button();
            btnSell = new Button();
            btnBuy = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Bisque;
            menuPanel.Controls.Add(btnHistory);
            menuPanel.Controls.Add(btnSell);
            menuPanel.Controls.Add(btnBuy);
            menuPanel.Controls.Add(label1);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(388, 727);
            menuPanel.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.ActiveCaptionText;
            btnHistory.ForeColor = Color.Transparent;
            btnHistory.Location = new Point(12, 416);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(235, 69);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Histroy";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnSell
            // 
            btnSell.BackColor = SystemColors.ActiveCaptionText;
            btnSell.ForeColor = Color.Transparent;
            btnSell.Location = new Point(12, 274);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(235, 69);
            btnSell.TabIndex = 2;
            btnSell.Text = "Sell Product";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = SystemColors.ActiveCaptionText;
            btnBuy.ForeColor = Color.Transparent;
            btnBuy.Location = new Point(12, 137);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(235, 69);
            btnBuy.TabIndex = 1;
            btnBuy.Text = "Buy Or Add Product";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(372, 43);
            label1.TabIndex = 0;
            label1.Text = "B and B Enterprises";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1097, 732);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1482, 727);
            Controls.Add(pictureBox1);
            Controls.Add(menuPanel);
            ForeColor = Color.Black;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Label label1;
        private Button btnBuy;
        private Button btnHistory;
        private Button btnSell;
        private PictureBox pictureBox1;
    }
}