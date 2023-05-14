namespace InventoryManagementSystem
{
    partial class Settings
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.chkISecurity = new System.Windows.Forms.CheckBox();
            this.txtSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 958);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.txtUserID);
            this.panel5.Controls.Add(this.txtDatabase);
            this.panel5.Controls.Add(this.txtDataSource);
            this.panel5.Controls.Add(this.chkISecurity);
            this.panel5.Controls.Add(this.txtSave);
            this.panel5.Controls.Add(this.lblPassword);
            this.panel5.Controls.Add(this.lblUserID);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(280, 893);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 958);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(834, 893);
            // 
            // lblTopUser
            // 
            this.lblTopUser.Click += new System.EventHandler(this.lblTopUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 359);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(262, 25);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(12, 311);
            this.txtUserID.MaxLength = 50;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(262, 25);
            this.txtUserID.TabIndex = 18;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(12, 258);
            this.txtDatabase.MaxLength = 50;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(262, 25);
            this.txtDatabase.TabIndex = 17;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(12, 210);
            this.txtDataSource.MaxLength = 50;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(262, 25);
            this.txtDataSource.TabIndex = 16;
            // 
            // chkISecurity
            // 
            this.chkISecurity.AutoSize = true;
            this.chkISecurity.Location = new System.Drawing.Point(12, 390);
            this.chkISecurity.Name = "chkISecurity";
            this.chkISecurity.Size = new System.Drawing.Size(136, 21);
            this.chkISecurity.TabIndex = 15;
            this.chkISecurity.Text = "Integrated Security";
            this.chkISecurity.UseVisualStyleBackColor = true;
            this.chkISecurity.CheckedChanged += new System.EventHandler(this.chkISecurity_CheckedChanged);
            // 
            // txtSave
            // 
            this.txtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSave.FlatAppearance.BorderSize = 2;
            this.txtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSave.Location = new System.Drawing.Point(12, 417);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(262, 41);
            this.txtSave.TabIndex = 14;
            this.txtSave.Text = "&SAVE";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 339);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(12, 291);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 17);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Server";
            // 
            // Settings
            // 
            this.AcceptButton = this.txtSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 958);
            this.Name = "Settings";
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.CheckBox chkISecurity;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}