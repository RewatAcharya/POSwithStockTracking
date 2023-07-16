namespace BandB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPartName = new TextBox();
            BtnAdd = new Button();
            txtHRNo = new TextBox();
            label2 = new Label();
            txtPartNo = new TextBox();
            label3 = new Label();
            txtPurchaseRate = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtSellRate = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnSearchForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "PartName: ";
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(147, 74);
            txtPartName.Margin = new Padding(4);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(289, 34);
            txtPartName.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.DarkCyan;
            BtnAdd.Location = new Point(224, 297);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(166, 69);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // txtHRNo
            // 
            txtHRNo.Location = new Point(620, 71);
            txtHRNo.Margin = new Padding(4);
            txtHRNo.Name = "txtHRNo";
            txtHRNo.Size = new Size(289, 34);
            txtHRNo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 3;
            label2.Text = "HRNo.:";
            // 
            // txtPartNo
            // 
            txtPartNo.Location = new Point(147, 147);
            txtPartNo.Margin = new Padding(4);
            txtPartNo.Name = "txtPartNo";
            txtPartNo.Size = new Size(289, 34);
            txtPartNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 5;
            label3.Text = "PartNo.:";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Location = new Point(620, 147);
            txtPurchaseRate.Margin = new Padding(4);
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(289, 34);
            txtPurchaseRate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 147);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 7;
            label4.Text = "PurchaseRate:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(147, 231);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(289, 34);
            txtStock.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 234);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 9;
            label5.Text = "Stock:";
            // 
            // txtSellRate
            // 
            txtSellRate.Location = new Point(620, 231);
            txtSellRate.Margin = new Padding(4);
            txtSellRate.Name = "txtSellRate";
            txtSellRate.Size = new Size(289, 34);
            txtSellRate.TabIndex = 12;
            txtSellRate.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 231);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 11;
            label6.Text = "SellRate:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkCyan;
            btnClear.Location = new Point(411, 297);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 69);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearchForm
            // 
            btnSearchForm.BackColor = Color.DarkCyan;
            btnSearchForm.Location = new Point(594, 297);
            btnSearchForm.Margin = new Padding(4);
            btnSearchForm.Name = "btnSearchForm";
            btnSearchForm.Size = new Size(166, 69);
            btnSearchForm.TabIndex = 14;
            btnSearchForm.Text = "Operations";
            btnSearchForm.UseVisualStyleBackColor = false;
            btnSearchForm.Click += btnSearchForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(958, 418);
            Controls.Add(btnSearchForm);
            Controls.Add(btnClear);
            Controls.Add(txtSellRate);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPurchaseRate);
            Controls.Add(label4);
            Controls.Add(txtPartNo);
            Controls.Add(label3);
            Controls.Add(txtHRNo);
            Controls.Add(label2);
            Controls.Add(BtnAdd);
            Controls.Add(txtPartName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPartName;
        private Button BtnAdd;
        private TextBox txtHRNo;
        private Label label2;
        private TextBox txtPartNo;
        private Label label3;
        private TextBox txtPurchaseRate;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtSellRate;
        private Label label6;
        private Button btnClear;
        private Button btnSearchForm;
    }
}