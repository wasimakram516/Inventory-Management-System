using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Pricing : Sample2
    {
        Int64 proID;
        float PurchasePrice, Profit, profitPerc, profitAmount, Discount, discountPer, discountAmount, SalePrice, FinalSalePRice;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Pricing()
        {
            InitializeComponent();
            clsSelection.GetDropdownList("stp_SelectCatList", ddCategory, "Name", "CatID");
        }

        private void ddCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCategory.SelectedIndex != -1 && ddCategory.SelectedIndex != 0)
            {
                clsSelection.SelectProductsWithCategories(Convert.ToInt32(ddCategory.SelectedValue.ToString()), dataGridView1, gvProID, gvName, gvPPrice, gvProfit, gvDiscount, gvTotalSalePrice);
                MainClass.SNO(dataGridView1, "gvSNO");
                MainClass.DisableReset(pnlPricing);
                pnlPricing.Visible = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlPricing.Visible = true;
            MainClass.EnableReset(pnlPricing);
            txtProductName.Enabled = false;
            txtPP.Enabled = false;
           
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            proID = Convert.ToInt32(row.Cells["gvProID"].Value.ToString());
            txtProductName.Text = row.Cells["gvName"].Value.ToString();
            txtPP.Text = row.Cells["gvPPrice"].Value.ToString();
            txtProfit.Text = row.Cells["gvProfit"].Value.ToString();
            txtDisc.Text = row.Cells["gvDiscount"].Value.ToString();
            txtSP.Text = row.Cells["gvTotalSalePrice"].Value.ToString();
            PurchasePrice = Convert.ToSingle(txtPP.Text);
        }

        private void txtProfit_Validating(object sender, CancelEventArgs e)
        {
            if (txtProfit.Text != "")
            {
                if (!rg.Match(txtProfit.Text).Success)
                {
                    txtProfit.Focus();
                    txtProfit.SelectAll();
                }
                else
                {
                    Profit = Convert.ToSingle(txtProfit.Text);
                    profitPerc = Profit / 100;
                    profitAmount = PurchasePrice * profitPerc;
                    SalePrice = profitAmount + PurchasePrice;
                    FinalSalePRice = SalePrice;
                    txtSP.Text = FinalSalePRice.ToString();
                }
            }
            else
            {
                Profit = 0;
                profitPerc = Profit / 100;
                profitAmount = PurchasePrice * profitPerc;
                SalePrice = profitAmount + PurchasePrice;
                FinalSalePRice = SalePrice;
                txtSP.Text = FinalSalePRice.ToString();
            }
        }

        private void txtDisc_Validating(object sender, CancelEventArgs e)
        {
            if (txtDisc.Text != "")
            {
                if (!rg.Match(txtDisc.Text).Success)
                {
                    txtDisc.Focus();
                    txtDisc.SelectAll();
                }
                else
                {
                    Discount = Convert.ToSingle(txtDisc.Text);
                    discountPer = Discount / 100;
                    discountAmount = SalePrice * discountPer;
                    FinalSalePRice = SalePrice - discountAmount;
                    txtSP.Text = FinalSalePRice.ToString();
                }
            }
            else
            {
                Discount = 0;
                discountPer = Discount / 100;
                discountAmount = SalePrice * discountPer;
                FinalSalePRice = SalePrice - discountAmount;
                txtSP.Text = FinalSalePRice.ToString();
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ddCategory.SelectedIndex != -1 && ddCategory.SelectedIndex != 0)
            {
                if (txtPP.Text=="" && txtSP.Text == "" && txtDisc.Text == "")
                {
                    MainClass.ShowMsg("Enter price to update..!", "Error", "Error");
                }
                else if (txtProfit.Text == "" && txtDisc.Text == "")
                {
                    Profit = 0; Discount = 0;
                    if (Discount == 0 && Profit == 0)
                    {
                        SalePrice = PurchasePrice;
                        txtSP.Text = SalePrice.ToString();
                        clsUpdation.UpdatePrice(proID, PurchasePrice, Profit, Discount, SalePrice);
                        clsSelection.SelectProductsWithCategories(Convert.ToInt32(ddCategory.SelectedValue.ToString()), dataGridView1, gvProID, gvName, gvPPrice, gvProfit, gvDiscount, gvTotalSalePrice);
                        MainClass.DisableReset(pnlPricing);
                    }
                }
                else
                {
                    FinalSalePRice = SalePrice - discountAmount;
                    txtSP.Text = FinalSalePRice.ToString();
                    clsUpdation.UpdatePrice(proID, PurchasePrice, Profit, Discount, FinalSalePRice);
                    clsSelection.SelectProductsWithCategories(Convert.ToInt32(ddCategory.SelectedValue.ToString()), dataGridView1, gvProID, gvName, gvPPrice, gvProfit, gvDiscount, gvTotalSalePrice);
                    MainClass.DisableReset(pnlPricing);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void btnView_Click(object sender, EventArgs e)
        {

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
