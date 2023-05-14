using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PurchaseDetails : Sample2
    {
        float gt;
        public PurchaseDetails()
        {
            InitializeComponent();
        }

        private void PurchaseDetails_Load(object sender, EventArgs e)
        {
            clsSelection.GetDropdownListWithTwoParameters("stp_SelectPurchaseList", ddCompany, "CompanyName", "PurchaseID", "@month", dateTimePicker1.Value.Month, "@year", dateTimePicker1.Value.Year);
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            Purchases p = new InventoryManagementSystem.Purchases();
            MainClass.ShowWin(p, this, MDI.ActiveForm);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            clsSelection.GetDropdownListWithTwoParameters("stp_SelectPurchaseList", ddCompany, "CompanyName", "PurchaseID", "@month", dateTimePicker1.Value.Month, "@year", dateTimePicker1.Value.Year);
        }

        private void ddCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCompany.SelectedIndex != 0 && ddCompany.SelectedIndex != -1)
            {

                clsSelection.SelectPurchaseDetails(Convert.ToInt64(ddCompany.SelectedValue.ToString()), dataGridView1, gvPurDetailID, gvProID, gvName, gvQuantity, gvUnitPrice, gvTotalAmount);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                }
                lblGrossTotal.Text = gt.ToString();

            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + row.Cells["gvName"].Value.ToString() + " from purchase invoice ?\n\nWARNING...!\n\nDeletion will effect stock!",
               "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        clsInsertion.InsertDeletedItems(Convert.ToInt64(ddCompany.SelectedValue.ToString()), clsSelection.USERID, Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString()), DateTime.Today);
                        int Quantity;
                        int countStock = clsSelection.SelectProductQuantityInStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()));
                        if (countStock != 0)
                        {
                            Quantity = Convert.ToInt32(countStock);
                            Quantity -= Convert.ToInt32(row.Cells["gvQuantity"].Value.ToString());
                            clsUpdation.UpdateStock(Convert.ToInt32(row.Cells["gvProID"].Value.ToString()), Quantity);
                            float grossTotal =Convert.ToSingle(lblGrossTotal.Text)- Convert.ToSingle(row.Cells["gvTotalAmount"].Value.ToString());
                            lblGrossTotal.Text = grossTotal.ToString();
                            clsDeletion.delete(Convert.ToInt64(row.Cells["gvPurDetailID"].Value.ToString()), "stp_DeletePurchaseDetails", "@PurDetailID");
                            dataGridView1.Rows.Remove(row);
                        }
                        sc.Complete();
                    }
                }
            }
        }
    }
}
