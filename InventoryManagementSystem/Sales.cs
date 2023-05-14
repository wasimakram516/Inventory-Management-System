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
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$"); // to store whole numbers and decimal numbers
        string[] ProArr = new string[6];
        string ProName, Barcode;
        float gt = 0, SalePrice, Discount, MultipliedPrice, FinalSalePrice;
        Int64 proID, Quantity;
        bool checkProduct;


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (txtAmountGiven.Text=="")
                {
                    float disc = 0, gt = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        disc += Convert.ToSingle(row.Cells["gvDisc"].Value.ToString());
                        gt += Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                    }
                    txtGross.Text = gt.ToString();
                    txtTotalDiscount.Text = disc.ToString();
                }

                else if (txtAmountGiven.Text != "")
                {
                    float givenAmount = Convert.ToSingle(txtAmountGiven.Text);
                    if (givenAmount < Convert.ToSingle(txtGross.Text))
                    {
                        txtAmountGiven.Focus();
                        txtAmountGiven.SelectAll();
                    }
                    else
                    {
                        float returnAmount = Convert.ToSingle(txtAmountGiven.Text) - Convert.ToSingle(txtGross.Text);
                        txtChangeToGive.Text = returnAmount.ToString();
                    }
                }
                
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtGross.Text != "" && txtTotalDiscount.Text != "" && ddPaymentType.SelectedIndex != -1 && txtAmountGiven.Text != "" && txtChangeToGive.Text != "")
            {
                DialogResult dr = MessageBox.Show("\tTotal Amount   : " + txtGross.Text + "\n\tDiscount            : " + txtTotalDiscount.Text + "\n\tPayment Type  : " + ddPaymentType.SelectedItem +
                    "\n\tAmount Given  : " + txtAmountGiven.Text + "\n\tChange to give : " + txtChangeToGive.Text + "\n\nAre You Sure, Submit Current sale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    float disc, SP;
                    int QTY;
                    foreach (DataGridViewRow  item in dataGridView1.Rows)
                    {
                        disc = Convert.ToSingle( item.Cells["gvDisc"].Value.ToString());
                        SP= Convert.ToSingle(item.Cells["gvTotalAmount"].Value.ToString());
                        QTY= Convert.ToInt32(item.Cells["gvQuantity"].Value.ToString());
                        item.Cells["gvDisc"].Value = disc / QTY;
                        item.Cells["gvTotalAmount"].Value = SP / QTY;
                    }
                    clsInsertion.InsertSales(dataGridView1, "gvProID", "gvQuantity", "gvDisc", "gvTotalAmount", clsSelection.USERID, DateTime.Now, Convert.ToSingle(txtGross.Text), Convert.ToSingle(txtTotalDiscount.Text), Convert.ToSingle(txtAmountGiven.Text), Convert.ToSingle(txtChangeToGive.Text), ddPaymentType.SelectedItem.ToString());
                    grpSaleDetails.Visible = false;
                    MainClass.DisableReset(grpSaleDetails);
                    dataGridView1.Rows.Clear();
                    gt = 0;
                    lblGrossTotal.Text = gt.ToString();
                    txtBarcode.Focus();
                    txtBarcode.Text = "";
                    SalesReport SRP = new SalesReport();
                    SRP.Show();
                }

            }
            else
            {
                MainClass.ShowMsg("Press CheckOut Button / Alt+C and Fill details Completely!", "Error", "Error");
            }
        }

        private void txtAmountGiven_Validating(object sender, CancelEventArgs e)
        {
            if (!rg.Match(txtAmountGiven.Text).Success)
            {
                txtAmountGiven.Focus();
                txtAmountGiven.SelectAll();
            }
            else
            {
                if (txtAmountGiven.Text!="")
                {
                    float gt = Convert.ToSingle(txtGross.Text);
                    float givenAmount = Convert.ToSingle(txtAmountGiven.Text);
                    if (givenAmount < gt)
                    {
                        MainClass.ShowMsg("Given amount is in-sufficient!", "Error", "Error");
                        txtAmountGiven.Focus();
                        txtAmountGiven.SelectAll();
                    }
                    else
                    {
                        float returnAmount = Convert.ToSingle(txtAmountGiven.Text) - Convert.ToSingle(txtGross.Text);
                        txtChangeToGive.Text = returnAmount.ToString();
                    }
                }
                

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    float Q = 0, dis, SPrice, TPrice;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    Q = Convert.ToSingle(row.Cells["gvQuantity"].Value.ToString());
                    if (Q == 1)
                    {
                        gt = Convert.ToSingle(lblGrossTotal.Text);
                        gt = gt - Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                        lblGrossTotal.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (Q > 1)
                    {
                        Q--;
                        row.Cells["gvQuantity"].Value = Q;
                        dis = Convert.ToSingle(row.Cells["gvDisc"].Value.ToString());
                        dis = dis - Convert.ToSingle(ProArr[4]);
                        row.Cells["gvDisc"].Value = dis;
                        SPrice = Convert.ToSingle(row.Cells["gvUnitPrice"].Value.ToString());
                        TPrice = Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                        row.Cells["gvTotalAmount"].Value = (TPrice - SPrice) + Convert.ToSingle(ProArr[4]);
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            gt += Convert.ToSingle(item.Cells["gvTotalAmount"].Value.ToString());
                        }
                        lblGrossTotal.Text = gt.ToString();
                        gt = 0;
                    }
                }
            }
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                ProArr = clsSelection.GetProductDetailsForPrice(txtBarcode.Text);
                proID = Convert.ToInt32(ProArr[0]);
                ProName = ProArr[1];
                Barcode = ProArr[2];
                SalePrice = Convert.ToSingle(ProArr[3]);
                Discount = Convert.ToSingle(ProArr[4]);
                FinalSalePrice = Convert.ToSingle(ProArr[5]);
                if (txtBarcode.Text == Barcode)
                {
                    grpSaleDetails.Visible = true;
                    MainClass.EnableReset(grpSaleDetails);
                    int StockCount = 0, ProductCount = 0, NetCount;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (ProArr[0] == row.Cells["gvProID"].Value.ToString())
                        {
                            ProductCount = ProductCount + Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString());
                        }
                    }
                    StockCount = Convert.ToInt32(clsSelection.SelectProductQuantityInStock(Convert.ToInt32(ProArr[0])));
                    NetCount = StockCount - ProductCount;
                    if (NetCount <= 0)
                    {
                        MainClass.ShowMsg(ProArr[1] + " is out of stock", "Error", "Error");
                    }
                    else
                    {
                        if (dataGridView1.Rows.Count == 0)
                        {
                            dataGridView1.Rows.Add(proID, ProName, 1, SalePrice, Discount, FinalSalePrice);
                            txtBarcode.Focus();
                            txtBarcode.Text = "";
                            foreach (DataGridViewRow item in dataGridView1.Rows)
                            {
                                gt += Convert.ToSingle(item.Cells["gvTotalAmount"].Value.ToString());
                            }
                            lblGrossTotal.Text = gt.ToString();
                            gt = 0;
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["gvProID"].Value.ToString() == ProArr[0])
                                {
                                    checkProduct = true;
                                    break;
                                }
                                else
                                {
                                    checkProduct = false;
                                }
                            }

                            if (checkProduct == true)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells["gvProID"].Value.ToString() == ProArr[0]) // if a aproduct is already exists, then increase its quantity and price
                                    {
                                        Quantity = Convert.ToInt32(row.Cells["gvQuantity"].Value);
                                        Quantity = Quantity + 1;
                                        row.Cells["gvQuantity"].Value = Quantity;
                                        float totalSalePrice = SalePrice * Quantity;
                                        Discount = Convert.ToSingle(row.Cells["gvDisc"].Value.ToString()) + Convert.ToSingle(ProArr[4]); // ProArr[4] means the amount of discount which is being retrieved by database
                                        row.Cells["gvDisc"].Value = Discount;
                                        MultipliedPrice = totalSalePrice - Discount;
                                        row.Cells["gvTotalAmount"].Value = MultipliedPrice;
                                    }
                                }
                            }
                            else
                            {
                                dataGridView1.Rows.Add(proID, ProName, 1, SalePrice, Discount, FinalSalePrice);
                            }
                        }
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            gt += Convert.ToSingle(item.Cells["gvTotalAmount"].Value.ToString());
                        }
                        lblGrossTotal.Text = gt.ToString();
                        gt = 0;
                        txtBarcode.Focus();
                        txtBarcode.Text = "";
                    }
                }
                else
                {
                    txtBarcode.Text = "";
                    Array.Clear(ProArr, 0, ProArr.Length);
                    txtBarcode.Focus();
                }
            }
        }


        public override void btnView_Click(object sender, EventArgs e)
        {
            SalesDetails sd = new InventoryManagementSystem.SalesDetails();
            MainClass.ShowWin(sd, this, MDI.ActiveForm);
        }
    }
}