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
    public partial class SalesDetails : Sample
    {
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void btnLoadDetails_Click(object sender, EventArgs e)
        {
            clsSelection.SelectSaleDetails(dateTimePicker1.Value, dataGridView1, gvSaleID, gvTotal, gvDiscount, gvAmountGiven, gvAmountResturn,gvUserID, gvDoneBy);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sales s = new InventoryManagementSystem.Sales();
            MainClass.ShowWin(s, this, MDI.ActiveForm);
        }
        public static int SaleID=0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SaleID = Convert.ToInt32(row.Cells["gvSaleID"].Value.ToString());
                SalesReport SRP = new SalesReport();
                SRP.Show();
            }
        }
    }
}
