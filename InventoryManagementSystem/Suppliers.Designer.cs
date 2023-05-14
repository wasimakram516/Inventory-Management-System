namespace InventoryManagementSystem
{
    partial class Suppliers
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
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtNTN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errSupplier = new System.Windows.Forms.Label();
            this.errContactPerson = new System.Windows.Forms.Label();
            this.errPhone = new System.Windows.Forms.Label();
            this.erraddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPhone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvNTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errStatus = new System.Windows.Forms.Label();
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
            this.LeftPanel.Size = new System.Drawing.Size(280, 701);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.ddStatus);
            this.panel5.Controls.Add(this.txtAddress);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtNTN);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtPhone1);
            this.panel5.Controls.Add(this.txtPhone2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtContactName);
            this.panel5.Controls.Add(this.txtSupplierName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.errSupplier);
            this.panel5.Controls.Add(this.errContactPerson);
            this.panel5.Controls.Add(this.errPhone);
            this.panel5.Controls.Add(this.erraddress);
            this.panel5.Controls.Add(this.errStatus);
            this.panel5.Size = new System.Drawing.Size(280, 636);
            this.panel5.Controls.SetChildIndex(this.errStatus, 0);
            this.panel5.Controls.SetChildIndex(this.erraddress, 0);
            this.panel5.Controls.SetChildIndex(this.errPhone, 0);
            this.panel5.Controls.SetChildIndex(this.errContactPerson, 0);
            this.panel5.Controls.SetChildIndex(this.errSupplier, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.panel5.Controls.SetChildIndex(this.txtContactName, 0);
            this.panel5.Controls.SetChildIndex(this.label4, 0);
            this.panel5.Controls.SetChildIndex(this.label5, 0);
            this.panel5.Controls.SetChildIndex(this.txtPhone2, 0);
            this.panel5.Controls.SetChildIndex(this.txtPhone1, 0);
            this.panel5.Controls.SetChildIndex(this.label6, 0);
            this.panel5.Controls.SetChildIndex(this.txtNTN, 0);
            this.panel5.Controls.SetChildIndex(this.label7, 0);
            this.panel5.Controls.SetChildIndex(this.txtAddress, 0);
            this.panel5.Controls.SetChildIndex(this.ddStatus, 0);
            this.panel5.Controls.SetChildIndex(this.label8, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 701);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Size = new System.Drawing.Size(834, 636);
            this.panel6.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier / Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact Person\'s Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(12, 105);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(262, 25);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(12, 153);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(262, 25);
            this.txtContactName.TabIndex = 1;
            this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone 1";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(12, 249);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(262, 25);
            this.txtPhone2.TabIndex = 3;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(12, 201);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(262, 25);
            this.txtPhone1.TabIndex = 2;
            this.txtPhone1.TextChanged += new System.EventHandler(this.txtPhone1_TextChanged);
            // 
            // txtNTN
            // 
            this.txtNTN.Location = new System.Drawing.Point(12, 297);
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.Size = new System.Drawing.Size(262, 25);
            this.txtNTN.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "NTN #";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 345);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 61);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";
            // 
            // errSupplier
            // 
            this.errSupplier.AutoSize = true;
            this.errSupplier.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSupplier.ForeColor = System.Drawing.Color.OrangeRed;
            this.errSupplier.Location = new System.Drawing.Point(254, 85);
            this.errSupplier.Name = "errSupplier";
            this.errSupplier.Size = new System.Drawing.Size(20, 28);
            this.errSupplier.TabIndex = 13;
            this.errSupplier.Text = "*";
            this.errSupplier.Visible = false;
            // 
            // errContactPerson
            // 
            this.errContactPerson.AutoSize = true;
            this.errContactPerson.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContactPerson.ForeColor = System.Drawing.Color.OrangeRed;
            this.errContactPerson.Location = new System.Drawing.Point(254, 133);
            this.errContactPerson.Name = "errContactPerson";
            this.errContactPerson.Size = new System.Drawing.Size(20, 28);
            this.errContactPerson.TabIndex = 14;
            this.errContactPerson.Text = "*";
            this.errContactPerson.Visible = false;
            // 
            // errPhone
            // 
            this.errPhone.AutoSize = true;
            this.errPhone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPhone.ForeColor = System.Drawing.Color.OrangeRed;
            this.errPhone.Location = new System.Drawing.Point(254, 181);
            this.errPhone.Name = "errPhone";
            this.errPhone.Size = new System.Drawing.Size(20, 28);
            this.errPhone.TabIndex = 15;
            this.errPhone.Text = "*";
            this.errPhone.Visible = false;
            // 
            // erraddress
            // 
            this.erraddress.AutoSize = true;
            this.erraddress.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erraddress.ForeColor = System.Drawing.Color.OrangeRed;
            this.erraddress.Location = new System.Drawing.Point(254, 325);
            this.erraddress.Name = "erraddress";
            this.erraddress.Size = new System.Drawing.Size(20, 28);
            this.erraddress.TabIndex = 16;
            this.erraddress.Text = "*";
            this.erraddress.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 576);
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
            this.gvSupID,
            this.gvCompanyName,
            this.gvContactPerson,
            this.gvPhone1,
            this.gvPhone2,
            this.gvNTN,
            this.gvAddress,
            this.gvStatus});
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
            this.dataGridView1.Size = new System.Drawing.Size(828, 552);
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
            // gvSupID
            // 
            this.gvSupID.HeaderText = "Suppliers ID";
            this.gvSupID.Name = "gvSupID";
            this.gvSupID.ReadOnly = true;
            this.gvSupID.Visible = false;
            // 
            // gvCompanyName
            // 
            this.gvCompanyName.HeaderText = "Supplier / Company Name";
            this.gvCompanyName.Name = "gvCompanyName";
            this.gvCompanyName.ReadOnly = true;
            // 
            // gvContactPerson
            // 
            this.gvContactPerson.HeaderText = "Contact Person\'s Name";
            this.gvContactPerson.Name = "gvContactPerson";
            this.gvContactPerson.ReadOnly = true;
            // 
            // gvPhone1
            // 
            this.gvPhone1.HeaderText = "Phone 1";
            this.gvPhone1.Name = "gvPhone1";
            this.gvPhone1.ReadOnly = true;
            // 
            // gvPhone2
            // 
            this.gvPhone2.HeaderText = "Phone 2";
            this.gvPhone2.Name = "gvPhone2";
            this.gvPhone2.ReadOnly = true;
            // 
            // gvNTN
            // 
            this.gvNTN.HeaderText = "NTN #";
            this.gvNTN.Name = "gvNTN";
            this.gvNTN.ReadOnly = true;
            // 
            // gvAddress
            // 
            this.gvAddress.HeaderText = "Address";
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            // 
            // gvStatus
            // 
            this.gvStatus.HeaderText = "Status";
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.ddStatus.Location = new System.Drawing.Point(12, 429);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(262, 25);
            this.ddStatus.TabIndex = 17;
            this.ddStatus.SelectedIndexChanged += new System.EventHandler(this.ddStatus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status";
            // 
            // errStatus
            // 
            this.errStatus.AutoSize = true;
            this.errStatus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.errStatus.Location = new System.Drawing.Point(254, 409);
            this.errStatus.Name = "errStatus";
            this.errStatus.Size = new System.Drawing.Size(20, 28);
            this.errStatus.TabIndex = 19;
            this.errStatus.Text = "*";
            this.errStatus.Visible = false;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 701);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label erraddress;
        private System.Windows.Forms.Label errPhone;
        private System.Windows.Forms.Label errContactPerson;
        private System.Windows.Forms.Label errSupplier;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label errStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvNTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;
    }
}