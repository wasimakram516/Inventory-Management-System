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
    public partial class Stock : Sample
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            
            clsSelection.SelectAvailableStock(dataGridView1, gvProID, gvName, gvBarcode, gvCategory, gvExpiry,gvPP,gvSP,gvTotal, gvStock, gvStatus);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen home = new InventoryManagementSystem.HomeScreen();
            MainClass.ShowWin(home, this, MDI.ActiveForm);
        }
    }
}
