namespace InventoryManagementSystem
{
    partial class Purchases
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
            this.grossTotalPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGrossTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gridviewPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errQuantity = new System.Windows.Forms.Label();
            this.errBarcode = new System.Windows.Forms.Label();
            this.errCompany = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddCompanyAdd = new System.Windows.Forms.ComboBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlAddPurchase = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.errPrice = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grossTotalPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gridviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 756);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlAddPurchase);
            this.panel5.Size = new System.Drawing.Size(280, 696);
            this.panel5.Controls.SetChildIndex(this.pnlAddPurchase, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 756);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gridviewPanel);
            this.panel6.Controls.Add(this.grossTotalPanel);
            this.panel6.Size = new System.Drawing.Size(834, 696);
            this.panel6.Controls.SetChildIndex(this.grossTotalPanel, 0);
            this.panel6.Controls.SetChildIndex(this.gridviewPanel, 0);
            // 
            // grossTotalPanel
            // 
            this.grossTotalPanel.Controls.Add(this.tableLayoutPanel2);
            this.grossTotalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grossTotalPanel.Location = new System.Drawing.Point(0, 636);
            this.grossTotalPanel.Name = "grossTotalPanel";
            this.grossTotalPanel.Size = new System.Drawing.Size(834, 60);
            this.grossTotalPanel.TabIndex = 1;
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
            // gridviewPanel
            // 
            this.gridviewPanel.Controls.Add(this.dataGridView1);
            this.gridviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewPanel.Location = new System.Drawing.Point(0, 60);
            this.gridviewPanel.Name = "gridviewPanel";
            this.gridviewPanel.Size = new System.Drawing.Size(834, 576);
            this.gridviewPanel.TabIndex = 2;
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
            this.dataGridView1.Size = new System.Drawing.Size(834, 576);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
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
            this.gvUnitPrice.HeaderText = "Per Unit Price";
            this.gvUnitPrice.Name = "gvUnitPrice";
            this.gvUnitPrice.ReadOnly = true;
            // 
            // gvTotalAmount
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTotalAmount.HeaderText = "Total Amount";
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
            // errQuantity
            // 
            this.errQuantity.AutoSize = true;
            this.errQuantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errQuantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.errQuantity.Location = new System.Drawing.Point(247, 208);
            this.errQuantity.Name = "errQuantity";
            this.errQuantity.Size = new System.Drawing.Size(20, 28);
            this.errQuantity.TabIndex = 38;
            this.errQuantity.Text = "*";
            this.errQuantity.Visible = false;
            // 
            // errBarcode
            // 
            this.errBarcode.AutoSize = true;
            this.errBarcode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBarcode.ForeColor = System.Drawing.Color.OrangeRed;
            this.errBarcode.Location = new System.Drawing.Point(247, 56);
            this.errBarcode.Name = "errBarcode";
            this.errBarcode.Size = new System.Drawing.Size(20, 28);
            this.errBarcode.TabIndex = 36;
            this.errBarcode.Text = "*";
            this.errBarcode.Visible = false;
            // 
            // errCompany
            // 
            this.errCompany.AutoSize = true;
            this.errCompany.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCompany.ForeColor = System.Drawing.Color.OrangeRed;
            this.errCompany.Location = new System.Drawing.Point(247, 7);
            this.errCompany.Name = "errCompany";
            this.errCompany.Size = new System.Drawing.Size(20, 28);
            this.errCompany.TabIndex = 35;
            this.errCompany.Text = "*";
            this.errCompany.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company Name";
            // 
            // ddCompanyAdd
            // 
            this.ddCompanyAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCompanyAdd.FormattingEnabled = true;
            this.ddCompanyAdd.Location = new System.Drawing.Point(9, 28);
            this.ddCompanyAdd.Name = "ddCompanyAdd";
            this.ddCompanyAdd.Size = new System.Drawing.Size(258, 25);
            this.ddCompanyAdd.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 2;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(9, 259);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(258, 45);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "ADD TO CART";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(9, 76);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(258, 25);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged_1);
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarcode_Validating);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(9, 124);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(258, 25);
            this.txtProductName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(9, 228);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(258, 25);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtItems_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(6, 327);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(108, 37);
            this.lblTotalPrice.TabIndex = 34;
            this.lblTotalPrice.Text = "Rs. 0.00";
            // 
            // pnlAddPurchase
            // 
            this.pnlAddPurchase.Controls.Add(this.label4);
            this.pnlAddPurchase.Controls.Add(this.txtUnitPrice);
            this.pnlAddPurchase.Controls.Add(this.lblTotalPrice);
            this.pnlAddPurchase.Controls.Add(this.label8);
            this.pnlAddPurchase.Controls.Add(this.txtQuantity);
            this.pnlAddPurchase.Controls.Add(this.label7);
            this.pnlAddPurchase.Controls.Add(this.label6);
            this.pnlAddPurchase.Controls.Add(this.txtProductName);
            this.pnlAddPurchase.Controls.Add(this.txtBarcode);
            this.pnlAddPurchase.Controls.Add(this.label3);
            this.pnlAddPurchase.Controls.Add(this.btnCart);
            this.pnlAddPurchase.Controls.Add(this.ddCompanyAdd);
            this.pnlAddPurchase.Controls.Add(this.label2);
            this.pnlAddPurchase.Controls.Add(this.errCompany);
            this.pnlAddPurchase.Controls.Add(this.errBarcode);
            this.pnlAddPurchase.Controls.Add(this.errQuantity);
            this.pnlAddPurchase.Controls.Add(this.errPrice);
            this.pnlAddPurchase.Location = new System.Drawing.Point(3, 86);
            this.pnlAddPurchase.Name = "pnlAddPurchase";
            this.pnlAddPurchase.Size = new System.Drawing.Size(274, 373);
            this.pnlAddPurchase.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(9, 176);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(258, 25);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // errPrice
            // 
            this.errPrice.AutoSize = true;
            this.errPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.errPrice.Location = new System.Drawing.Point(247, 156);
            this.errPrice.Name = "errPrice";
            this.errPrice.Size = new System.Drawing.Size(20, 28);
            this.errPrice.TabIndex = 41;
            this.errPrice.Text = "*";
            this.errPrice.Visible = false;
            // 
            // Purchases
            // 
            this.AcceptButton = this.btnCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 756);
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grossTotalPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gridviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddPurchase.ResumeLayout(false);
            this.pnlAddPurchase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel gridviewPanel;
        private System.Windows.Forms.Panel grossTotalPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGrossTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlAddPurchase;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.ComboBox ddCompanyAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errCompany;
        private System.Windows.Forms.Label errBarcode;
        private System.Windows.Forms.Label errQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label errPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn gvRemove;
    }
}