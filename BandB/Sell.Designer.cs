namespace BandB
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            dateTime = new DateTimePicker();
            label1 = new Label();
            txtCustomerName = new TextBox();
            BtnSell = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStockSell = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtPricePerPiece = new TextBox();
            BtnClear = new Button();
            txtPrice = new TextBox();
            label9 = new Label();
            button1 = new Button();
            clearList = new Button();
            sellPointGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtPartNameSell = new TextBox();
            label10 = new Label();
            txtSearchProduct = new TextBox();
            ProductListView = new DataGridView();
            panelSellNow = new Panel();
            txtDiscount = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnPrint = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            txtTotalPrice = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtPartNo = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)sellPointGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductListView).BeginInit();
            panelSellNow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTime
            // 
            dateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(868, 16);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(320, 34);
            dateTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(811, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerName.Location = new Point(596, 65);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(301, 34);
            txtCustomerName.TabIndex = 2;
            // 
            // BtnSell
            // 
            BtnSell.BackColor = Color.Blue;
            BtnSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSell.ForeColor = Color.Transparent;
            BtnSell.Location = new Point(763, 531);
            BtnSell.Name = "BtnSell";
            BtnSell.Size = new Size(143, 69);
            BtnSell.TabIndex = 3;
            BtnSell.Text = "CheckOut";
            BtnSell.UseVisualStyleBackColor = false;
            BtnSell.Click += BtnSell_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(455, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(916, 123);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 6;
            label3.Text = "Name of item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(932, 68);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 8;
            label4.Text = "Stock:";
            // 
            // txtStockSell
            // 
            txtStockSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockSell.Location = new Point(1057, 65);
            txtStockSell.Name = "txtStockSell";
            txtStockSell.Size = new Size(301, 34);
            txtStockSell.TabIndex = 7;
            txtStockSell.TextChanged += txtStockSell_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(455, 123);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(596, 120);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(301, 34);
            txtAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1406, 68);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 11;
            label6.Text = "Price per piece:";
            // 
            // txtPricePerPiece
            // 
            txtPricePerPiece.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPricePerPiece.Location = new Point(1572, 65);
            txtPricePerPiece.Name = "txtPricePerPiece";
            txtPricePerPiece.ReadOnly = true;
            txtPricePerPiece.Size = new Size(166, 34);
            txtPricePerPiece.TabIndex = 12;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Blue;
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClear.ForeColor = Color.Transparent;
            BtnClear.Location = new Point(1027, 531);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(143, 69);
            BtnClear.TabIndex = 17;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(1477, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(261, 34);
            txtPrice.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1406, 123);
            label9.Name = "label9";
            label9.Size = new Size(58, 28);
            label9.TabIndex = 21;
            label9.Text = "Price:";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1027, 176);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 22;
            button1.Text = "Another";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // clearList
            // 
            clearList.BackColor = Color.Blue;
            clearList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearList.ForeColor = Color.Transparent;
            clearList.Location = new Point(1291, 531);
            clearList.Name = "clearList";
            clearList.Size = new Size(143, 69);
            clearList.TabIndex = 23;
            clearList.Text = "Clear List";
            clearList.UseVisualStyleBackColor = false;
            clearList.Click += clearList_Click;
            // 
            // sellPointGrid
            // 
            sellPointGrid.BackgroundColor = Color.White;
            sellPointGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sellPointGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            sellPointGrid.Location = new Point(455, 244);
            sellPointGrid.Name = "sellPointGrid";
            sellPointGrid.RowHeadersWidth = 51;
            sellPointGrid.RowTemplate.Height = 29;
            sellPointGrid.Size = new Size(1326, 266);
            sellPointGrid.TabIndex = 24;
            sellPointGrid.CellDoubleClick += sellPointGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Address";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Item Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 74;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "PricePerPiece";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 70;
            // 
            // txtPartNameSell
            // 
            txtPartNameSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPartNameSell.Location = new Point(1057, 120);
            txtPartNameSell.Name = "txtPartNameSell";
            txtPartNameSell.ReadOnly = true;
            txtPartNameSell.Size = new Size(301, 34);
            txtPartNameSell.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 21);
            label10.Name = "label10";
            label10.Size = new Size(70, 28);
            label10.TabIndex = 32;
            label10.Text = "Search";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProduct.Location = new Point(12, 52);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(412, 34);
            txtSearchProduct.TabIndex = 31;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // ProductListView
            // 
            ProductListView.BackgroundColor = Color.White;
            ProductListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListView.Location = new Point(11, 92);
            ProductListView.Name = "ProductListView";
            ProductListView.RowHeadersWidth = 51;
            ProductListView.RowTemplate.Height = 29;
            ProductListView.Size = new Size(413, 508);
            ProductListView.TabIndex = 30;
            ProductListView.CellDoubleClick += ProductListView_CellContentClick_1;
            // 
            // panelSellNow
            // 
            panelSellNow.Controls.Add(txtDiscount);
            panelSellNow.Controls.Add(pictureBox2);
            panelSellNow.Controls.Add(pictureBox1);
            panelSellNow.Controls.Add(btnPrint);
            panelSellNow.Controls.Add(tableLayoutPanel1);
            panelSellNow.Controls.Add(button2);
            panelSellNow.Controls.Add(txtTotalPrice);
            panelSellNow.Controls.Add(label8);
            panelSellNow.Controls.Add(label7);
            panelSellNow.Location = new Point(11, 12);
            panelSellNow.Name = "panelSellNow";
            panelSellNow.Size = new Size(1675, 597);
            panelSellNow.TabIndex = 33;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.Location = new Point(800, 151);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(261, 34);
            txtDiscount.TabIndex = 37;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1067, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(692, 591);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(692, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Blue;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.Transparent;
            btnPrint.Location = new Point(729, 304);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(143, 69);
            btnPrint.TabIndex = 28;
            btnPrint.Text = "Print and Sell";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(-444, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(413, 588);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(918, 304);
            button2.Name = "button2";
            button2.Size = new Size(143, 69);
            button2.TabIndex = 26;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPrice.Location = new Point(800, 203);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(261, 34);
            txtTotalPrice.TabIndex = 24;
            txtTotalPrice.TextChanged += txtTotalPrice_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(701, 151);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 23;
            label8.Text = "Discount:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(701, 206);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 22;
            label7.Text = "Total:";
            label7.Click += label7_Click;
            // 
            // txtPartNo
            // 
            txtPartNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPartNo.Location = new Point(596, 18);
            txtPartNo.Name = "txtPartNo";
            txtPartNo.Size = new Size(207, 34);
            txtPartNo.TabIndex = 34;
            txtPartNo.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1804, 621);
            Controls.Add(txtPartNo);
            Controls.Add(panelSellNow);
            Controls.Add(label10);
            Controls.Add(txtSearchProduct);
            Controls.Add(ProductListView);
            Controls.Add(txtPartNameSell);
            Controls.Add(sellPointGrid);
            Controls.Add(clearList);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(BtnClear);
            Controls.Add(txtPricePerPiece);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtStockSell);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSell);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(dateTime);
            MaximizeBox = false;
            Name = "Sell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell";
            Load += Sell_Load;
            ((System.ComponentModel.ISupportInitialize)sellPointGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductListView).EndInit();
            panelSellNow.ResumeLayout(false);
            panelSellNow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTime;
        private Label label1;
        private TextBox txtCustomerName;
        private Button BtnSell;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStockSell;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtPricePerPiece;
        private Button BtnClear;
        private TextBox txtPrice;
        private Label label9;
        private Button button1;
        private Button clearList;
        private DataGridView sellPointGrid;
        private TextBox txtPartNameSell;
        private Label label10;
        private TextBox txtSearchProduct;
        private DataGridView ProductListView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panelSellNow;
        private TextBox txtTotalPrice;
        private Label label8;
        private Label label7;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtPartNo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtDiscount;
    }
}