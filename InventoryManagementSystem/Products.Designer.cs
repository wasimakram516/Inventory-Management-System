namespace InventoryManagementSystem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.errProductName = new System.Windows.Forms.Label();
            this.errBarcode = new System.Windows.Forms.Label();
            this.errExpiryDate = new System.Windows.Forms.Label();
            this.errCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 697);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtbarcode);
            this.panel5.Controls.Add(this.ddCategory);
            this.panel5.Controls.Add(this.dtExpiryDate);
            this.panel5.Controls.Add(this.txtProductName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.errProductName);
            this.panel5.Controls.Add(this.errBarcode);
            this.panel5.Controls.Add(this.errExpiryDate);
            this.panel5.Controls.Add(this.errCategory);
            this.panel5.Size = new System.Drawing.Size(280, 637);
            this.panel5.Controls.SetChildIndex(this.errCategory, 0);
            this.panel5.Controls.SetChildIndex(this.errExpiryDate, 0);
            this.panel5.Controls.SetChildIndex(this.errBarcode, 0);
            this.panel5.Controls.SetChildIndex(this.errProductName, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.label4, 0);
            this.panel5.Controls.SetChildIndex(this.label5, 0);
            this.panel5.Controls.SetChildIndex(this.txtProductName, 0);
            this.panel5.Controls.SetChildIndex(this.dtExpiryDate, 0);
            this.panel5.Controls.SetChildIndex(this.ddCategory, 0);
            this.panel5.Controls.SetChildIndex(this.txtbarcode, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 697);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(834, 637);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 108);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(262, 25);
            this.txtProductName.TabIndex = 0;
            // 
            // dtExpiryDate
            // 
            this.dtExpiryDate.CustomFormat = "";
            this.dtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpiryDate.Location = new System.Drawing.Point(12, 206);
            this.dtExpiryDate.Name = "dtExpiryDate";
            this.dtExpiryDate.Size = new System.Drawing.Size(262, 25);
            this.dtExpiryDate.TabIndex = 3;
            // 
            // ddCategory
            // 
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Location = new System.Drawing.Point(12, 254);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(262, 25);
            this.ddCategory.TabIndex = 4;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(12, 156);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(262, 25);
            this.txtbarcode.TabIndex = 1;
            // 
            // errProductName
            // 
            this.errProductName.AutoSize = true;
            this.errProductName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errProductName.ForeColor = System.Drawing.Color.OrangeRed;
            this.errProductName.Location = new System.Drawing.Point(254, 88);
            this.errProductName.Name = "errProductName";
            this.errProductName.Size = new System.Drawing.Size(20, 28);
            this.errProductName.TabIndex = 11;
            this.errProductName.Text = "*";
            this.errProductName.Visible = false;
            // 
            // errBarcode
            // 
            this.errBarcode.AutoSize = true;
            this.errBarcode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBarcode.ForeColor = System.Drawing.Color.OrangeRed;
            this.errBarcode.Location = new System.Drawing.Point(254, 136);
            this.errBarcode.Name = "errBarcode";
            this.errBarcode.Size = new System.Drawing.Size(20, 28);
            this.errBarcode.TabIndex = 12;
            this.errBarcode.Text = "*";
            this.errBarcode.Visible = false;
            // 
            // errExpiryDate
            // 
            this.errExpiryDate.AutoSize = true;
            this.errExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExpiryDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.errExpiryDate.Location = new System.Drawing.Point(89, 188);
            this.errExpiryDate.Name = "errExpiryDate";
            this.errExpiryDate.Size = new System.Drawing.Size(12, 15);
            this.errExpiryDate.TabIndex = 14;
            this.errExpiryDate.Text = "*";
            this.errExpiryDate.Visible = false;
            // 
            // errCategory
            // 
            this.errCategory.AutoSize = true;
            this.errCategory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCategory.ForeColor = System.Drawing.Color.OrangeRed;
            this.errCategory.Location = new System.Drawing.Point(254, 234);
            this.errCategory.Name = "errCategory";
            this.errCategory.Size = new System.Drawing.Size(20, 28);
            this.errCategory.TabIndex = 15;
            this.errCategory.Text = "*";
            this.errCategory.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 577);
            this.groupBox2.TabIndex = 2;
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
            this.gvBarcode,
            this.gvExpiryDate,
            this.gvCatID,
            this.gvCatName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(828, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 73;
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
            // gvBarcode
            // 
            this.gvBarcode.HeaderText = "Barcode #";
            this.gvBarcode.Name = "gvBarcode";
            this.gvBarcode.ReadOnly = true;
            // 
            // gvExpiryDate
            // 
            this.gvExpiryDate.HeaderText = "Expiry Date";
            this.gvExpiryDate.Name = "gvExpiryDate";
            this.gvExpiryDate.ReadOnly = true;
            // 
            // gvCatID
            // 
            this.gvCatID.HeaderText = "Category ID";
            this.gvCatID.Name = "gvCatID";
            this.gvCatID.ReadOnly = true;
            this.gvCatID.Visible = false;
            // 
            // gvCatName
            // 
            this.gvCatName.HeaderText = "Category Name";
            this.gvCatName.Name = "gvCatName";
            this.gvCatName.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 697);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.DateTimePicker dtExpiryDate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errProductName;
        private System.Windows.Forms.Label errBarcode;
        private System.Windows.Forms.Label errExpiryDate;
        private System.Windows.Forms.Label errCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCatName;
    }
}