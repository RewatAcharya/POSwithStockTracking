namespace BandB
{
    partial class SearchProducts
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
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtSearchProduct = new TextBox();
            BtnSearch = new Button();
            showPurchaseRate = new Button();
            updateDelete = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            txtSellRateUD = new TextBox();
            label6 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtPurchaseRateUD = new TextBox();
            label4 = new Label();
            txtPartNo = new TextBox();
            label3 = new Label();
            txtHRNoUD = new TextBox();
            label2 = new Label();
            BtnUpdate = new Button();
            txtPartNameUD = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            updateDelete.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(808, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += updateAndDelete;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(69, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProduct.Location = new Point(166, 34);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(289, 34);
            txtSearchProduct.TabIndex = 2;
            txtSearchProduct.TextChanged += BtnSearch_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.DarkCyan;
            BtnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSearch.ForeColor = Color.Cornsilk;
            BtnSearch.Location = new Point(450, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 38);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // showPurchaseRate
            // 
            showPurchaseRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showPurchaseRate.BackColor = Color.Khaki;
            showPurchaseRate.ImageAlign = ContentAlignment.TopRight;
            showPurchaseRate.Location = new Point(733, 12);
            showPurchaseRate.Name = "showPurchaseRate";
            showPurchaseRate.Size = new Size(94, 29);
            showPurchaseRate.TabIndex = 4;
            showPurchaseRate.TextAlign = ContentAlignment.TopRight;
            showPurchaseRate.UseVisualStyleBackColor = false;
            showPurchaseRate.Click += showPurchaseRate_Click;
            // 
            // updateDelete
            // 
            updateDelete.Controls.Add(btnClose);
            updateDelete.Controls.Add(btnDelete);
            updateDelete.Controls.Add(txtSellRateUD);
            updateDelete.Controls.Add(label6);
            updateDelete.Controls.Add(txtStock);
            updateDelete.Controls.Add(label5);
            updateDelete.Controls.Add(txtPurchaseRateUD);
            updateDelete.Controls.Add(label4);
            updateDelete.Controls.Add(txtPartNo);
            updateDelete.Controls.Add(label3);
            updateDelete.Controls.Add(txtHRNoUD);
            updateDelete.Controls.Add(label2);
            updateDelete.Controls.Add(BtnUpdate);
            updateDelete.Controls.Add(txtPartNameUD);
            updateDelete.Controls.Add(label1);
            updateDelete.Location = new Point(3, 12);
            updateDelete.Name = "updateDelete";
            updateDelete.Size = new Size(824, 426);
            updateDelete.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkOrange;
            btnClose.Location = new Point(530, 281);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(166, 69);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOrange;
            btnDelete.Location = new Point(350, 281);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 69);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSellRateUD
            // 
            txtSellRateUD.Location = new Point(530, 205);
            txtSellRateUD.Margin = new Padding(4);
            txtSellRateUD.Name = "txtSellRateUD";
            txtSellRateUD.Size = new Size(256, 27);
            txtSellRateUD.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 205);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 26;
            label6.Text = "SellRate:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(109, 198);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(267, 27);
            txtStock.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 201);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 24;
            label5.Text = "Stock:";
            // 
            // txtPurchaseRateUD
            // 
            txtPurchaseRateUD.Location = new Point(530, 121);
            txtPurchaseRateUD.Margin = new Padding(4);
            txtPurchaseRateUD.Name = "txtPurchaseRateUD";
            txtPurchaseRateUD.Size = new Size(256, 27);
            txtPurchaseRateUD.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 22;
            label4.Text = "PurchaseRate:";
            // 
            // txtPartNo
            // 
            txtPartNo.Location = new Point(109, 118);
            txtPartNo.Margin = new Padding(4);
            txtPartNo.Name = "txtPartNo";
            txtPartNo.Size = new Size(267, 27);
            txtPartNo.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 20;
            label3.Text = "PartNo.:";
            // 
            // txtHRNoUD
            // 
            txtHRNoUD.Location = new Point(530, 45);
            txtHRNoUD.Margin = new Padding(4);
            txtHRNoUD.Name = "txtHRNoUD";
            txtHRNoUD.Size = new Size(256, 27);
            txtHRNoUD.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 18;
            label2.Text = "HRNo.:";
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.DarkCyan;
            BtnUpdate.Location = new Point(163, 281);
            BtnUpdate.Margin = new Padding(4);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(166, 69);
            BtnUpdate.TabIndex = 17;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // txtPartNameUD
            // 
            txtPartNameUD.Location = new Point(109, 48);
            txtPartNameUD.Margin = new Padding(4);
            txtPartNameUD.Name = "txtPartNameUD";
            txtPartNameUD.Size = new Size(267, 27);
            txtPartNameUD.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 15;
            label1.Text = "PartName: ";
            // 
            // SearchProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(832, 450);
            Controls.Add(updateDelete);
            Controls.Add(showPurchaseRate);
            Controls.Add(BtnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            MaximizeBox = false;
            Name = "SearchProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Products";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            updateDelete.ResumeLayout(false);
            updateDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtSearchProduct;
        private Button BtnSearch;
        private Button showPurchaseRate;
        private Panel updateDelete;
        private Button btnSearchForm;
        private Button btnDelete;
        private TextBox txtSellRateUD;
        private Label label6;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPurchaseRateUD;
        private Label label4;
        private TextBox txtPartNo;
        private Label label3;
        private TextBox txtHRNoUD;
        private Label label2;
        private Button BtnUpdate;
        private TextBox txtPartNameUD;
        private Label label1;
        private Button btnClose;
    }
}