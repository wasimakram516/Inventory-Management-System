namespace InventoryManagementSystem
{
    partial class SalesDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAmountGiven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAmountResturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 958);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLoadDetails);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(280, 893);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 958);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Size = new System.Drawing.Size(834, 893);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnLoadDetails
            // 
            this.btnLoadDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDetails.Location = new System.Drawing.Point(12, 75);
            this.btnLoadDetails.Name = "btnLoadDetails";
            this.btnLoadDetails.Size = new System.Drawing.Size(262, 53);
            this.btnLoadDetails.TabIndex = 2;
            this.btnLoadDetails.Text = "LOAD DETAILS";
            this.btnLoadDetails.UseVisualStyleBackColor = true;
            this.btnLoadDetails.Click += new System.EventHandler(this.btnLoadDetails_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvSNO,
            this.gvSaleID,
            this.gvTotal,
            this.gvDiscount,
            this.gvAmountGiven,
            this.gvAmountResturn,
            this.gvUserID,
            this.gvDoneBy});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 893);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr. No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 68;
            // 
            // gvSaleID
            // 
            this.gvSaleID.HeaderText = "Sale ID";
            this.gvSaleID.Name = "gvSaleID";
            this.gvSaleID.ReadOnly = true;
            this.gvSaleID.Visible = false;
            // 
            // gvTotal
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.gvTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvTotal.HeaderText = "Total Price (Rs.)";
            this.gvTotal.Name = "gvTotal";
            this.gvTotal.ReadOnly = true;
            // 
            // gvDiscount
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.gvDiscount.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvDiscount.HeaderText = "Discount (Rs.)";
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            // 
            // gvAmountGiven
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.gvAmountGiven.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvAmountGiven.HeaderText = "Amount Given (Rs.)";
            this.gvAmountGiven.Name = "gvAmountGiven";
            this.gvAmountGiven.ReadOnly = true;
            // 
            // gvAmountResturn
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.gvAmountResturn.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvAmountResturn.HeaderText = "Amount Returned (Rs.)";
            this.gvAmountResturn.Name = "gvAmountResturn";
            this.gvAmountResturn.ReadOnly = true;
            // 
            // gvUserID
            // 
            this.gvUserID.HeaderText = "User ID";
            this.gvUserID.Name = "gvUserID";
            this.gvUserID.ReadOnly = true;
            this.gvUserID.Visible = false;
            // 
            // gvDoneBy
            // 
            this.gvDoneBy.HeaderText = "Sales Man";
            this.gvDoneBy.Name = "gvDoneBy";
            this.gvDoneBy.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::InventoryManagementSystem.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 65);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SalesDetails
            // 
            this.AcceptButton = this.btnLoadDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 958);
            this.Name = "SalesDetails";
            this.Text = "SalesDetails";
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAmountGiven;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAmountResturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDoneBy;
    }
}