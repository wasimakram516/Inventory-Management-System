namespace InventoryManagementSystem
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grossTotalPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGrossTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grpSaleDetails = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.ddPaymentType = new System.Windows.Forms.ComboBox();
            this.txtChangeToGive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gridviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grossTotalPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grpSaleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 698);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grpSaleDetails);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Size = new System.Drawing.Size(280, 638);
            this.panel5.Controls.SetChildIndex(this.panel7, 0);
            this.panel5.Controls.SetChildIndex(this.grpSaleDetails, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 698);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grossTotalPanel);
            this.panel6.Controls.Add(this.gridviewPanel);
            this.panel6.Size = new System.Drawing.Size(834, 638);
            this.panel6.Controls.SetChildIndex(this.gridviewPanel, 0);
            this.panel6.Controls.SetChildIndex(this.grossTotalPanel, 0);
            // 
            // gridviewPanel
            // 
            this.gridviewPanel.Controls.Add(this.dataGridView1);
            this.gridviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewPanel.Location = new System.Drawing.Point(0, 60);
            this.gridviewPanel.Name = "gridviewPanel";
            this.gridviewPanel.Size = new System.Drawing.Size(834, 578);
            this.gridviewPanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvProID,
            this.gvName,
            this.gvQuantity,
            this.gvUnitPrice,
            this.gvDisc,
            this.gvTotalAmount,
            this.gvRemove});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 578);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvProID
            // 
            this.gvProID.HeaderText = "Product ID";
            this.gvProID.Name = "gvProID";
            this.gvProID.ReadOnly = true;
            this.gvProID.Visible = false;
            // 
            // gvName
            // 
            this.gvName.HeaderText = "Product Name";
            this.gvName.Name = "gvName";
            this.gvName.ReadOnly = true;
            // 
            // gvQuantity
            // 
            this.gvQuantity.HeaderText = "Quantity";
            this.gvQuantity.Name = "gvQuantity";
            this.gvQuantity.ReadOnly = true;
            // 
            // gvUnitPrice
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.gvUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvUnitPrice.HeaderText = "Per Unit Price (Rs.)";
            this.gvUnitPrice.Name = "gvUnitPrice";
            this.gvUnitPrice.ReadOnly = true;
            // 
            // gvDisc
            // 
            this.gvDisc.HeaderText = "Discount (Rs.)";
            this.gvDisc.Name = "gvDisc";
            this.gvDisc.ReadOnly = true;
            // 
            // gvTotalAmount
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTotalAmount.HeaderText = "Final Sale Price (Rs.)";
            this.gvTotalAmount.Name = "gvTotalAmount";
            this.gvTotalAmount.ReadOnly = true;
            // 
            // gvRemove
            // 
            this.gvRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvRemove.HeaderText = "Action";
            this.gvRemove.Name = "gvRemove";
            this.gvRemove.ReadOnly = true;
            this.gvRemove.Text = "Remove";
            this.gvRemove.UseColumnTextForButtonValue = true;
            this.gvRemove.Width = 50;
            // 
            // grossTotalPanel
            // 
            this.grossTotalPanel.Controls.Add(this.tableLayoutPanel2);
            this.grossTotalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grossTotalPanel.Location = new System.Drawing.Point(0, 578);
            this.grossTotalPanel.Name = "grossTotalPanel";
            this.grossTotalPanel.Size = new System.Drawing.Size(834, 60);
            this.grossTotalPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblGrossTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(834, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGrossTotal
            // 
            this.lblGrossTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrossTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossTotal.Location = new System.Drawing.Point(420, 0);
            this.lblGrossTotal.Name = "lblGrossTotal";
            this.lblGrossTotal.Size = new System.Drawing.Size(411, 60);
            this.lblGrossTotal.TabIndex = 17;
            this.lblGrossTotal.Text = "Rs. 0.00";
            this.lblGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(411, 60);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gross Total:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(12, 23);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(261, 25);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarcode_Validating);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtBarcode);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 61);
            this.panel7.TabIndex = 3;
            // 
            // grpSaleDetails
            // 
            this.grpSaleDetails.Controls.Add(this.btnPay);
            this.grpSaleDetails.Controls.Add(this.btnCheckout);
            this.grpSaleDetails.Controls.Add(this.ddPaymentType);
            this.grpSaleDetails.Controls.Add(this.txtChangeToGive);
            this.grpSaleDetails.Controls.Add(this.label7);
            this.grpSaleDetails.Controls.Add(this.label6);
            this.grpSaleDetails.Controls.Add(this.txtAmountGiven);
            this.grpSaleDetails.Controls.Add(this.label5);
            this.grpSaleDetails.Controls.Add(this.txtTotalDiscount);
            this.grpSaleDetails.Controls.Add(this.label4);
            this.grpSaleDetails.Controls.Add(this.txtGross);
            this.grpSaleDetails.Controls.Add(this.label3);
            this.grpSaleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSaleDetails.ForeColor = System.Drawing.Color.White;
            this.grpSaleDetails.Location = new System.Drawing.Point(0, 121);
            this.grpSaleDetails.Name = "grpSaleDetails";
            this.grpSaleDetails.Size = new System.Drawing.Size(280, 517);
            this.grpSaleDetails.TabIndex = 4;
            this.grpSaleDetails.TabStop = false;
            this.grpSaleDetails.Text = "Payments";
            this.grpSaleDetails.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 2;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(151, 287);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(122, 61);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "&PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 2;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Location = new System.Drawing.Point(12, 287);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(122, 61);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "&Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // ddPaymentType
            // 
            this.ddPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPaymentType.FormattingEnabled = true;
            this.ddPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.ddPaymentType.Location = new System.Drawing.Point(12, 144);
            this.ddPaymentType.Name = "ddPaymentType";
            this.ddPaymentType.Size = new System.Drawing.Size(261, 25);
            this.ddPaymentType.TabIndex = 2;
            // 
            // txtChangeToGive
            // 
            this.txtChangeToGive.Enabled = false;
            this.txtChangeToGive.Location = new System.Drawing.Point(12, 244);
            this.txtChangeToGive.Name = "txtChangeToGive";
            this.txtChangeToGive.Size = new System.Drawing.Size(261, 25);
            this.txtChangeToGive.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Change To Return";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Type";
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.Location = new System.Drawing.Point(12, 194);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(261, 25);
            this.txtAmountGiven.TabIndex = 3;
            this.txtAmountGiven.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountGiven_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount Given";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Enabled = false;
            this.txtTotalDiscount.Location = new System.Drawing.Point(12, 92);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.Size = new System.Drawing.Size(261, 25);
            this.txtTotalDiscount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Discount";
            // 
            // txtGross
            // 
            this.txtGross.Enabled = false;
            this.txtGross.Location = new System.Drawing.Point(12, 43);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(261, 25);
            this.txtGross.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gross Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 698);
            this.Name = "Sales";
            this.Text = "Sales";
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gridviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grossTotalPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.grpSaleDetails.ResumeLayout(false);
            this.grpSaleDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridviewPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel grossTotalPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGrossTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn gvRemove;
        private System.Windows.Forms.GroupBox grpSaleDetails;
        private System.Windows.Forms.ComboBox ddPaymentType;
        private System.Windows.Forms.TextBox txtChangeToGive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCheckout;
    }
}