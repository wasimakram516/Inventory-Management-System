namespace InventoryManagementSystem
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPricing = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCatagories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(280, 881);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(280, 816);
            // 
            // panel3
            // 
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(834, 881);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(834, 816);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblLogout);
            this.panel4.Controls.SetChildIndex(this.lblTopUser, 0);
            this.panel4.Controls.SetChildIndex(this.lblLogout, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPricing, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSuppliers, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPurchases, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStock, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProducts, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCatagories, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 816);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPricing
            // 
            this.btnPricing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPricing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPricing.FlatAppearance.BorderSize = 2;
            this.btnPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricing.Image = global::InventoryManagementSystem.Properties.Resources.Cash_register_icon__2_;
            this.btnPricing.Location = new System.Drawing.Point(627, 166);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Size = new System.Drawing.Size(204, 157);
            this.btnPricing.TabIndex = 7;
            this.btnPricing.Text = "Pricing";
            this.btnPricing.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuppliers.FlatAppearance.BorderSize = 2;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Image = global::InventoryManagementSystem.Properties.Resources.icons8_business_building_64;
            this.btnSuppliers.Location = new System.Drawing.Point(419, 166);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(202, 157);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchases.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPurchases.FlatAppearance.BorderSize = 2;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Image = global::InventoryManagementSystem.Properties.Resources.icons8_money_bag_80;
            this.btnPurchases.Location = new System.Drawing.Point(211, 166);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(202, 157);
            this.btnPurchases.TabIndex = 5;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSales.FlatAppearance.BorderSize = 2;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Image = global::InventoryManagementSystem.Properties.Resources.icons8_total_sales_64;
            this.btnSales.Location = new System.Drawing.Point(3, 166);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(202, 157);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStock.FlatAppearance.BorderSize = 2;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Image = global::InventoryManagementSystem.Properties.Resources.icons8_combo_chart_64;
            this.btnStock.Location = new System.Drawing.Point(627, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(204, 157);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducts.FlatAppearance.BorderSize = 2;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Image = global::InventoryManagementSystem.Properties.Resources.icons8_trolley_64;
            this.btnProducts.Location = new System.Drawing.Point(419, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(202, 157);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCatagories
            // 
            this.btnCatagories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatagories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCatagories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCatagories.FlatAppearance.BorderSize = 2;
            this.btnCatagories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatagories.Image = global::InventoryManagementSystem.Properties.Resources.icons8_add_shopping_cart_100;
            this.btnCatagories.Location = new System.Drawing.Point(211, 3);
            this.btnCatagories.Name = "btnCatagories";
            this.btnCatagories.Size = new System.Drawing.Size(202, 157);
            this.btnCatagories.TabIndex = 1;
            this.btnCatagories.Text = "Categories";
            this.btnCatagories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCatagories.UseVisualStyleBackColor = true;
            this.btnCatagories.Click += new System.EventHandler(this.btnCatagories_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsers.FlatAppearance.BorderSize = 2;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Image = global::InventoryManagementSystem.Properties.Resources.icons8_add_user_male_64;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(202, 157);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(738, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(96, 65);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 816);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 881);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPricing;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCatagories;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label label2;
    }
}