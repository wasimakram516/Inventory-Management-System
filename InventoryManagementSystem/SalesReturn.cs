using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class SalesReturn : Sample
    {
        public SalesReturn()
        {
            InitializeComponent();

        }
        private void SalesReturn_Load(object sender, EventArgs e)
        {
            txtSalesID.Focus();
        }

        Regex rg = new Regex(@"^[0-9]*$");
        int ProQTY, RemainProQTY,RefundQTY;
        float RefundAmount;
        Hashtable ht = new Hashtable();


        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen hom = new InventoryManagementSystem.HomeScreen();
            MainClass.ShowWin(hom, this, MDI.ActiveForm);
        }

        private void txtSalesID_TextChanged(object sender, EventArgs e)
        {

            if (!rg.Match(txtSalesID.Text).Success)
            {
                txtSalesID.Focus();
                txtSalesID.SelectAll();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtSalesID.Text != "")
            {
                MainClass.DisableReset(pnlDetails);
                pnlDetails.Visible = true;
                pnlRefund.Visible = true;
                clsSelection.SalesReturn(Convert.ToInt64(txtSalesID.Text), dataGridView1, gvSaleID, gvProID, gvProName, gvBarcode, gvQuantity, gvUnitPrice, gvPrice, gvTotal, gvDiscount, gvTotalDiscount, gvDiscountedPrice, gvAmountGiven, gvAmountResturn, gvDoneBy, gvPaymentType, gvDate);
                MainClass.SNO(dataGridView1, "gvSNO");
                pnlDetails.Visible = true;
                MainClass.Disable(pnlDetails);
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["gvDate"].Value.ToString());
                txtSalesPerson.Text = dataGridView1.Rows[0].Cells["gvDoneBy"].Value.ToString();
                txtPymentType.Text = dataGridView1.Rows[0].Cells["gvPaymentType"].Value.ToString();
                txtTotalPrice.Text = dataGridView1.Rows[0].Cells["gvTotal"].Value.ToString();
                txtTotalDiscount.Text = dataGridView1.Rows[0].Cells["gvTotalDiscount"].Value.ToString();
                txtAmountGiven.Text = dataGridView1.Rows[0].Cells["gvAmountGiven"].Value.ToString();
                txtAmountRetuen.Text = dataGridView1.Rows[0].Cells["gvAmountResturn"].Value.ToString();

                txtBarcode.Focus();
            }
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (txtBarcode.Text == row.Cells["gvBarcode"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are you sure, You want to refund?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    Int64 ProID = Convert.ToInt64(row.Cells["gvProID"].Value.ToString());
                                    float PerUnitPrice = Convert.ToSingle(row.Cells["gvUnitPrice"].Value.ToString());
                                    ProQTY = Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString());
                                    float Disc = Convert.ToSingle(row.Cells["gvDiscount"].Value.ToString());
                                    float PerUnitDisc = Disc / ProQTY;
                                    float ProPrice = PerUnitPrice - PerUnitDisc;
                                    RemainProQTY = Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString()) - 1;
                                    row.Cells["gvPrice"].Value = RemainProQTY * Convert.ToSingle(row.Cells["gvUnitPrice"].Value.ToString());
                                    RefundAmount += ProPrice;
                                    txtRefAmount.Text = Math.Round(RefundAmount, 0).ToString();
                                    if (RemainProQTY == 0)
                                    {

                                        if (ht.ContainsKey(row.Cells["gvProID"].Value))
                                        {
                                            Int64 htProID = Convert.ToInt64(row.Cells["gvProID"].Value.ToString());
                                            ht[htProID] = Convert.ToInt32(htProID) - 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["gvProID"].Value, 1);
                                        }
                                        txtBarcode.Focus();
                                        txtBarcode.SelectAll();
                                        dataGridView1.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["gvQuantity"].Value = RemainProQTY;
                                        row.Cells["gvDiscount"].Value = RemainProQTY * PerUnitDisc;
                                        row.Cells["gvDiscountedPrice"].Value = Convert.ToSingle(row.Cells["gvPrice"].Value.ToString()) - Convert.ToSingle(row.Cells["gvDiscount"].Value.ToString());
                                        if (ht.ContainsKey(row.Cells["gvProID"].Value))
                                        {
                                            Int64 htProID = Convert.ToInt64(row.Cells["gvProID"].Value.ToString());
                                            ht[htProID] = Convert.ToInt32(htProID) + 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["gvProID"].Value, 1);
                                        }
                                        txtBarcode.Focus();
                                        txtBarcode.Text="";
                                    }
                                }
                                break;
                            }
                        }
                        sc.Complete();
                    }
                }
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (txtRefAmount.Text != "" && ht.Count > 0 && txtSalesID.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += clsInsertion.InsertSalesRefund(Convert.ToInt64(txtSalesID.Text), DateTime.Now, clsSelection.USERID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Value), Convert.ToSingle(txtRefAmount.Text));
                            int currentQTY = (int)clsSelection.SelectProductQuantityInStock(Convert.ToInt64(de.Key));
                            int FinalQTY = currentQTY + Convert.ToInt16(de.Value);
                            clsUpdation.UpdateStock(Convert.ToInt64(de.Key), FinalQTY);
                            clsUpdation.UpdateQuantityInSaleDetails(Convert.ToInt64(de.Key), Convert.ToInt64(txtSalesID.Text), RemainProQTY);
                        }
                        if (x > 0)
                        {
                            MainClass.ShowMsg("Return and Refund is Successful!", "Success", "Success");
                            clsSelection.SalesReturn(Convert.ToInt64(txtSalesID.Text), dataGridView1, gvSaleID, gvProID, gvProName, gvBarcode, gvQuantity, gvUnitPrice, gvPrice, gvTotal, gvDiscount, gvTotalDiscount, gvDiscountedPrice, gvAmountGiven, gvAmountResturn, gvDoneBy, gvPaymentType, gvDate);
                            MainClass.SNO(dataGridView1, "gvSNO");
                            x = 0;
                            ht.Clear();
                            //dataGridView1.Rows.Clear();
                            txtBarcode.Text = "";
                            txtSalesID.Text = "";
                            txtRefAmount.Text = "";
                            txtBarcode.Focus();
                        }
                        sc.Complete();
                       
                    }
                }
            }
            else
            {
                MainClass.ShowMsg("Please, Provide complete details!", "Error", "error");
            }
        }


    }
}
