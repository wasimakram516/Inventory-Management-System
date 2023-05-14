namespace InventoryManagementSystem
{
    partial class PurchaseDetails
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
            this.gvPurDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grossTotalPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGrossTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlViewPurchase = new System.Windows.Forms.Panel();
            this.ddCompany = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
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
            this.pnlViewPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 721);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlViewPurchase);
            this.panel5.Size = new System.Drawing.Size(280, 661);
            this.panel5.Controls.SetChildIndex(this.pnlViewPurchase, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 721);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grossTotalPanel);
            this.panel6.Controls.Add(this.gridviewPanel);
            this.panel6.Size = new System.Drawing.Size(834, 661);
            this.panel6.Controls.SetChildIndex(this.gridviewPanel, 0);
            this.panel6.Controls.SetChildIndex(this.grossTotalPanel, 0);
            // 
            // gridviewPanel
            // 
            this.gridviewPanel.Controls.Add(this.dataGridView1);
            this.gridviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewPanel.Location = new System.Drawing.Point(0, 60);
            this.gridviewPanel.Name = "gridviewPanel";
            this.gridviewPanel.Size = new System.Drawing.Size(834, 601);
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
            this.gvPurDetailID,
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
            this.dataGridView1.Size = new System.Drawing.Size(834, 601);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // gvPurDetailID
            // 
            this.gvPurDetailID.HeaderText = "Purchase Detail ID";
            this.gvPurDetailID.Name = "gvPurDetailID";
            this.gvPurDetailID.ReadOnly = true;
            this.gvPurDetailID.Visible = false;
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
            this.gvRemove.HeaderText = "Remove";
            this.gvRemove.Name = "gvRemove";
            this.gvRemove.ReadOnly = true;
            this.gvRemove.Text = "Remove";
            this.gvRemove.UseColumnTextForButtonValue = true;
            // 
            // grossTotalPanel
            // 
            this.grossTotalPanel.Controls.Add(this.tableLayoutPanel2);
            this.grossTotalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grossTotalPanel.Location = new System.Drawing.Point(0, 601);
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
            // pnlViewPurchase
            // 
            this.pnlViewPurchase.Controls.Add(this.ddCompany);
            this.pnlViewPurchase.Controls.Add(this.label9);
            this.pnlViewPurchase.Controls.Add(this.dateTimePicker1);
            this.pnlViewPurchase.Controls.Add(this.label11);
            this.pnlViewPurchase.Location = new System.Drawing.Point(3, 92);
            this.pnlViewPurchase.Name = "pnlViewPurchase";
            this.pnlViewPurchase.Size = new System.Drawing.Size(274, 108);
            this.pnlViewPurchase.TabIndex = 26;
            // 
            // ddCompany
            // 
            this.ddCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCompany.FormattingEnabled = true;
            this.ddCompany.Location = new System.Drawing.Point(9, 77);
            this.ddCompany.Name = "ddCompany";
            this.ddCompany.Size = new System.Drawing.Size(258, 25);
            this.ddCompany.TabIndex = 1;
            this.ddCompany.SelectedIndexChanged += new System.EventHandler(this.ddCompany_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Select Supplier / Company";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM- yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 25);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Select Month";
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 721);
            this.Name = "PurchaseDetails";
            this.Text = "Purchase Details";
            this.Load += new System.EventHandler(this.PurchaseDetails_Load);
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
            this.pnlViewPurchase.ResumeLayout(false);
            this.pnlViewPurchase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel gridviewPanel;
        private System.Windows.Forms.Panel grossTotalPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGrossTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlViewPurchase;
        private System.Windows.Forms.ComboBox ddCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPurDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn gvRemove;
    }
}