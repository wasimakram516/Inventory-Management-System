namespace InventoryManagementSystem
{
    partial class Pricing
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
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPricing = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPricing.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 650);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlPricing);
            this.panel5.Controls.Add(this.ddCategory);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Size = new System.Drawing.Size(280, 590);
            this.panel5.Controls.SetChildIndex(this.label5, 0);
            this.panel5.Controls.SetChildIndex(this.ddCategory, 0);
            this.panel5.Controls.SetChildIndex(this.pnlPricing, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 650);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(834, 590);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // ddCategory
            // 
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Location = new System.Drawing.Point(12, 90);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(262, 25);
            this.ddCategory.TabIndex = 5;
            this.ddCategory.SelectedIndexChanged += new System.EventHandler(this.ddCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 530);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
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
            this.gvSNO,
            this.gvProID,
            this.gvName,
            this.gvPPrice,
            this.gvProfit,
            this.gvDiscount,
            this.gvTotalSalePrice});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(828, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 68;
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
            // gvPPrice
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.gvPPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvPPrice.HeaderText = "Purchase Price (Rs.)";
            this.gvPPrice.Name = "gvPPrice";
            this.gvPPrice.ReadOnly = true;
            // 
            // gvProfit
            // 
            this.gvProfit.HeaderText = "Profit %";
            this.gvProfit.Name = "gvProfit";
            this.gvProfit.ReadOnly = true;
            // 
            // gvDiscount
            // 
            this.gvDiscount.HeaderText = "Discount %";
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            // 
            // gvTotalSalePrice
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvTotalSalePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTotalSalePrice.HeaderText = "Total Sale Price (Rs.)";
            this.gvTotalSalePrice.Name = "gvTotalSalePrice";
            this.gvTotalSalePrice.ReadOnly = true;
            // 
            // pnlPricing
            // 
            this.pnlPricing.Controls.Add(this.txtProductName);
            this.pnlPricing.Controls.Add(this.label3);
            this.pnlPricing.Controls.Add(this.label7);
            this.pnlPricing.Controls.Add(this.txtSP);
            this.pnlPricing.Controls.Add(this.label6);
            this.pnlPricing.Controls.Add(this.txtDisc);
            this.pnlPricing.Controls.Add(this.label4);
            this.pnlPricing.Controls.Add(this.txtProfit);
            this.pnlPricing.Controls.Add(this.label2);
            this.pnlPricing.Controls.Add(this.txtPP);
            this.pnlPricing.Location = new System.Drawing.Point(6, 121);
            this.pnlPricing.Name = "pnlPricing";
            this.pnlPricing.Size = new System.Drawing.Size(268, 301);
            this.pnlPricing.TabIndex = 7;
            this.pnlPricing.Visible = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(6, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(258, 25);
            this.txtProductName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Purchase Price";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(6, 232);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(258, 25);
            this.txtSP.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Sale Price";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(6, 183);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(258, 25);
            this.txtDisc.TabIndex = 36;
            this.txtDisc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDisc_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Discount %";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(6, 133);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(258, 25);
            this.txtProfit.TabIndex = 34;
            this.txtProfit.Validating += new System.ComponentModel.CancelEventHandler(this.txtProfit_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Profit %";
            // 
            // txtPP
            // 
            this.txtPP.Enabled = false;
            this.txtPP.Location = new System.Drawing.Point(6, 83);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(258, 25);
            this.txtPP.TabIndex = 32;
            // 
            // Pricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 650);
            this.Name = "Pricing";
            this.Text = "Pricing";
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPricing.ResumeLayout(false);
            this.pnlPricing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlPricing;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalSalePrice;
    }
}