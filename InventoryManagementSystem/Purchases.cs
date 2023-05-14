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
using System.Transactions;

namespace InventoryManagementSystem
{
    public partial class Purchases : Sample2
    {
        float QTY, price, total, grossTotal;
        float gt = 0;
        int count;
        Int64 PurchaseID;
        string[] proArr = new string[3];
        Int64 proID;
        string barcode;

        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }
            clsSelection.GetDropdownList("stp_SelectSuppliersList", ddCompanyAdd, "CompanyName", "SupID");
        }


        public override void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Remove(row);
                gt = 0;
                lblGrossTotal.Text = "Rs. 0.00";
            }
            MainClass.EnableReset(pnlAddPurchase);
            pnlAddPurchase.Visible = true;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (TransactionScope sc = new TransactionScope())
                {

                    PurchaseID = clsInsertion.InsertPurchases(DateTime.Now, clsSelection.USERID, Convert.ToInt32(ddCompanyAdd.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        count += clsInsertion.InsertPurchaseDetails(PurchaseID, Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString()), Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString()));
                        if (clsSelection.SelectProductIDFromPrice(Convert.ToInt32(row.Cells["gvProID"].Value.ToString())))
                        {
                            clsUpdation.UpdatePurchasePrice(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Convert.ToSingle(row.Cells["gvUnitPrice"].Value.ToString()));
                        }
                        else
                        {
                            clsInsertion.InsertPrice(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Convert.ToSingle(row.Cells["gvUnitPrice"].Value.ToString()));
                        }
                        int Quantity;
                        int countStock = clsSelection.SelectProductQuantityInStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()));
                        if (countStock != 0)
                        {
                            Quantity = Convert.ToInt32(countStock);
                            Quantity += Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString());
                            clsUpdation.UpdateStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Quantity);
                        }
                        else
                        {
                            Int64 proID =clsSelection.SelectProductIDInStock(Convert.ToInt64(row.Cells["gvProID"].Value.ToString()));
                            if (proID>0)
                            {
                                Quantity = Convert.ToInt32(countStock);
                                Quantity += Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString());
                                clsUpdation.UpdateStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Quantity);
                            }
                            else
                            {
                                clsInsertion.InsertStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString()));
                            }
                            
                        }
                    }
                    if (count > 0)
                    {
                        MainClass.ShowMsg("Purchase invoice created successfully!", "Success", "Success");
                        MainClass.Disable(pnlAddPurchase);
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            dataGridView1.Rows.Remove(row);
                            grossTotal = 0;
                            lblGrossTotal.Text = "Rs. 0.00";
                        }
                    }
                    else
                    {
                        MainClass.ShowMsg("Unable to create purchase invoice!", "Error", "Error");
                    }
                    sc.Complete();
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Remove(row);
                gt = 0;
                lblGrossTotal.Text = "Rs. 0.00";
            }
            PurchaseDetails pd = new InventoryManagementSystem.PurchaseDetails();
            MainClass.ShowWin(pd, this, MDI.ActiveForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBarcode_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                proArr = clsSelection.GetProductDetails(txtBarcode.Text);
                proID = Convert.ToInt32(proArr[0]);
                txtProductName.Text = proArr[1];
                barcode = proArr[2];
                txtProductName.Enabled = false;
                if (barcode == null)
                {
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
                if (barcode != null)
                {
                    txtUnitPrice.Focus();
                }
            }
            else
            {
                proID = 0;
                txtProductName.Text = "";
                txtUnitPrice.Text = "";
                Array.Clear(proArr, 0, proArr.Length);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtUnitPrice.Text!="")
            {
                if (!rg.Match(txtUnitPrice.Text).Success)
                {
                    txtUnitPrice.SelectAll();
                }
            }
        }

        private void txtItems_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" )
            {
                if (rg.Match(txtQuantity.Text).Success)
                {
                    QTY = Convert.ToSingle(txtQuantity.Text);

                    price = Convert.ToSingle(txtUnitPrice.Text);
                    total = QTY * price;
                    lblTotalPrice.Text = total.ToString("###########.##");
                }
                else
                {
                    txtQuantity.SelectAll();
                }
            }
            else
            {
                lblTotalPrice.Text = "Rs. 0.00";
            }
        }

        private void btnCart_Click_1(object sender, EventArgs e)
        {
            if (ddCompanyAdd.SelectedIndex == 0) { errCompany.Visible = true; } else { errCompany.Visible = false; }
            if (txtBarcode.Text == "") { errBarcode.Visible = true; } else { errBarcode.Visible = false; }
            if (txtQuantity.Text == "") { errQuantity.Visible = true; } else { errQuantity.Visible = false; }
            if (txtUnitPrice.Text == "") { errPrice.Visible = true; } else { errPrice.Visible = false; }
            if (errQuantity.Visible || errBarcode.Visible || errCompany.Visible|| errPrice.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory1", "Error", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(proID, txtProductName.Text, txtQuantity.Text,txtUnitPrice.Text, lblTotalPrice.Text);
                grossTotal += Convert.ToSingle(lblTotalPrice.Text);
                lblGrossTotal.Text = grossTotal.ToString();
                txtBarcode.Text = "";
                txtProductName.Text = "";
                txtUnitPrice.Text = "";
                txtQuantity.Text = "";
                lblTotalPrice.Text = "Rs. 0.00";
                txtBarcode.Focus();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (pnlAddPurchase.Visible == true)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    grossTotal -= Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                    lblGrossTotal.Text = grossTotal.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }


        }

    }
}
