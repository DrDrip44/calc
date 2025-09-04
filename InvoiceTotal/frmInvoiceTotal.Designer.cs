namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            txtEnterSubtotal = new TextBox();
            label2 = new Label();
            txtDiscountPct = new TextBox();
            label3 = new Label();
            txtDiscountAmt = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            label5 = new Label();
            txtNumberOfInvoices = new TextBox();
            label6 = new Label();
            txtTotalOfInvoices = new TextBox();
            label7 = new Label();
            txtAvgOfInvoices = new TextBox();
            btnClear = new Button();
            label8 = new Label();
            txtSubtotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter &Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEnterSubtotal
            // 
            txtEnterSubtotal.Location = new Point(131, 15);
            txtEnterSubtotal.Name = "txtEnterSubtotal";
            txtEnterSubtotal.Size = new Size(100, 23);
            txtEnterSubtotal.TabIndex = 1;
            txtEnterSubtotal.TextChanged += txtEnterSubtotal_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 76);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(131, 73);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(100, 23);
            txtDiscountPct.TabIndex = 3;
            txtDiscountPct.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 105);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(131, 102);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(100, 23);
            txtDiscountAmt.TabIndex = 5;
            txtDiscountAmt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 134);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(131, 131);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(228, 171);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(414, 171);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 46);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 8;
            label5.Text = "Number of invoices:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfInvoices
            // 
            txtNumberOfInvoices.Location = new Point(389, 43);
            txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            txtNumberOfInvoices.ReadOnly = true;
            txtNumberOfInvoices.Size = new Size(100, 23);
            txtNumberOfInvoices.TabIndex = 9;
            txtNumberOfInvoices.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 76);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 10;
            label6.Text = "Total of invoices:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotalOfInvoices
            // 
            txtTotalOfInvoices.Location = new Point(389, 72);
            txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            txtTotalOfInvoices.ReadOnly = true;
            txtTotalOfInvoices.Size = new Size(100, 23);
            txtTotalOfInvoices.TabIndex = 11;
            txtTotalOfInvoices.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 105);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 12;
            label7.Text = "Average of invoices:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAvgOfInvoices
            // 
            txtAvgOfInvoices.Location = new Point(388, 102);
            txtAvgOfInvoices.Name = "txtAvgOfInvoices";
            txtAvgOfInvoices.ReadOnly = true;
            txtAvgOfInvoices.Size = new Size(100, 23);
            txtAvgOfInvoices.TabIndex = 13;
            txtAvgOfInvoices.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(321, 171);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 47);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 15;
            label8.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(131, 44);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 16;
            txtSubtotal.TabStop = false;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(511, 212);
            Controls.Add(txtSubtotal);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(txtAvgOfInvoices);
            Controls.Add(label7);
            Controls.Add(txtTotalOfInvoices);
            Controls.Add(label6);
            Controls.Add(txtNumberOfInvoices);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtEnterSubtotal);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEnterSubtotal;
        private Label label2;
        private TextBox txtDiscountPct;
        private Label label3;
        private TextBox txtDiscountAmt;
        private Label label4;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
        private Label label5;
        private TextBox txtNumberOfInvoices;
        private Label label6;
        private TextBox txtTotalOfInvoices;
        private Label label7;
        private TextBox txtAvgOfInvoices;
        private Button btnClear;
        private Label label8;
        private TextBox txtSubtotal;
    }
}