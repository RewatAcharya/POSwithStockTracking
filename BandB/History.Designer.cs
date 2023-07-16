namespace BandB
{
    partial class History
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BtnSearch = new Button();
            txtSearchProduct = new TextBox();
            lblSearch = new Label();
            dataHistroy = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataHistroy).BeginInit();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.DarkCyan;
            BtnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSearch.ForeColor = Color.Cornsilk;
            BtnSearch.Location = new Point(500, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 38);
            BtnSearch.TabIndex = 8;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProduct.Location = new Point(216, 35);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(289, 34);
            txtSearchProduct.TabIndex = 7;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(131, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Search";
            // 
            // dataHistroy
            // 
            dataHistroy.AllowUserToAddRows = false;
            dataHistroy.AllowUserToDeleteRows = false;
            dataHistroy.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataHistroy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataHistroy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataHistroy.Location = new Point(-7, 91);
            dataHistroy.Name = "dataHistroy";
            dataHistroy.ReadOnly = true;
            dataHistroy.RowHeadersWidth = 51;
            dataHistroy.RowTemplate.Height = 29;
            dataHistroy.Size = new Size(829, 518);
            dataHistroy.TabIndex = 5;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(819, 610);
            Controls.Add(BtnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(lblSearch);
            Controls.Add(dataHistroy);
            MaximizeBox = false;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dataHistroy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearch;
        private TextBox txtSearchProduct;
        private Label lblSearch;
        private DataGridView dataHistroy;
    }
}