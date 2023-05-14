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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen home = new InventoryManagementSystem.HomeScreen();
            MainClass.ShowWin(home, this, MDI.ActiveForm);
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
