using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace InventoryManagementSystem
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        ReportDocument rd;
        private void SalesReport_Load(object sender, EventArgs e)
        {
            rd = new ReportDocument();
            if (SalesDetails.SaleID==0)
            {
                clsSelection.ShowReciept(rd, crystalReportViewer1, "stp_GetSalesReciept", "@UserID", clsSelection.USERID);
            }

            else
            {
                clsSelection.ShowReciept(rd, crystalReportViewer1, "stp_GetSalesRecieptWithSaleID", "@SaleID", SalesDetails.SaleID);
            }
        }

        private void SalesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd!=null)
            {
                rd.Close();
            }
        }
    }
}
