using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI md = new InventoryManagementSystem.MDI();
            lblTopUser.Text = clsSelection.NAME;
            md.logOutToolStripMenuItem.Visible = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            MainClass.ShowWin(usr, this, MDI.ActiveForm);
        }

        private void btnCatagories_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            MainClass.ShowWin(cat, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products pro = new InventoryManagementSystem.Products();
            MainClass.ShowWin(pro, this, MDI.ActiveForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stok = new InventoryManagementSystem.Stock();
            MainClass.ShowWin(stok, this, MDI.ActiveForm);
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            Purchases p = new InventoryManagementSystem.Purchases();
            MainClass.ShowWin(p, this, MDI.ActiveForm);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers sup = new InventoryManagementSystem.Suppliers();
            MainClass.ShowWin(sup, this, MDI.ActiveForm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales sup = new InventoryManagementSystem.Sales();
            MainClass.ShowWin(sup, this, MDI.ActiveForm);
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            Pricing pri = new InventoryManagementSystem.Pricing();
            MainClass.ShowWin(pri, this, MDI.ActiveForm);
        }

        private void btnProductReturn_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn();
            MainClass.ShowWin(sr, this, MDI.ActiveForm);
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, You want to Logout?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                Login log = new Login();
                MainClass.ShowWin(log, this, MDI.ActiveForm);
            }
        }
    }
}
