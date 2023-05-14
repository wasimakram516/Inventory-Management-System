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
    public partial class Products : Sample2
    {
        int edit;
        Int64 prodID;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            clsSelection.GetDropdownList("stp_SelectCatList", ddCategory, "Name", "CatID");
            MainClass.Disable(panel5);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
           
            MainClass.EnableReset(panel5);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(panel5);
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "") { errProductName.Visible = true; } else { errProductName.Visible = false; }
            if (txtbarcode.Text == "") { errBarcode.Visible = true; } else { errBarcode.Visible = false; }
            //if (txtPrice.Text == "") { errPrice.Visible = true; } else { errPrice.Visible = false; }
            if (dtExpiryDate.Value.Date < DateTime.Now.Date) { errExpiryDate.Visible = true;errExpiryDate.Text = "Invalid Date"; } else { errExpiryDate.Visible = false; }
            if (ddCategory.SelectedIndex == 0|| ddCategory.SelectedIndex == -1) { errCategory.Visible = true; } else { errCategory.Visible = false; }
            
            if (errProductName.Visible == true || errBarcode.Visible == true || errCategory.Visible == true)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else if (errExpiryDate.Visible == true)
            {
                MainClass.ShowMsg("Invalid date!", "Error", "Error");
            }
            else
            {
                if (edit == 0)//Code for save button
                {
                    if (dtExpiryDate.Value.Date== DateTime.Now.Date)
                    {
                        clsInsertion.InsertProducts(txtProductName.Text, txtbarcode.Text,   Convert.ToInt32(ddCategory.SelectedValue), null);
                    }

                    else
                    {
                        clsInsertion.InsertProducts(txtProductName.Text, txtbarcode.Text,  Convert.ToInt32(ddCategory.SelectedValue), dtExpiryDate.Value);
                    }
                    
                    clsSelection.SelectProducts(dataGridView1,gvProID,gvName,gvBarcode,gvExpiryDate,gvCatID,gvCatName);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    MainClass.DisableReset(panel5);
                }

                else if (edit == 1)//code for update button
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update " + txtProductName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (dtExpiryDate.Value.Date==DateTime.Now.Date)
                        {
                            clsUpdation.UpdateProducts(prodID, txtProductName.Text, txtbarcode.Text, Convert.ToInt32(ddCategory.SelectedValue), null);

                        }

                        else
                        {
                            clsUpdation.UpdateProducts(prodID, txtProductName.Text, txtbarcode.Text,  Convert.ToInt32(ddCategory.SelectedValue), dtExpiryDate.Value);
                        }
                       
                        clsSelection.SelectProducts(dataGridView1, gvProID, gvName, gvBarcode,  gvExpiryDate, gvCatID, gvCatName);
                        MainClass.SNO(dataGridView1, "gvSNO");
                        MainClass.DisableReset(panel5);
                    }

                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtProductName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.delete(prodID, "stp_DeleteProducts", "@ProID");
                    clsSelection.SelectProducts(dataGridView1, gvProID, gvName, gvBarcode, gvExpiryDate, gvCatID, gvCatName);
                    MainClass.DisableReset(panel5);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            clsSelection.SelectProducts(dataGridView1, gvProID, gvName, gvBarcode, gvExpiryDate, gvCatID, gvCatName);

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectProducts(dataGridView1, gvProID, gvName, gvBarcode, gvExpiryDate, gvCatID, gvCatName,txtSearch.Text);
            }
            else
            {
                clsSelection.SelectProducts(dataGridView1, gvProID, gvName, gvBarcode, gvExpiryDate, gvCatID, gvCatName);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["gvProID"].Value.ToString());
                txtProductName.Text = row.Cells["gvName"].Value.ToString();
                txtbarcode.Text = row.Cells["gvBarcode"].Value.ToString();
                //txtPrice.Text = row.Cells["gvPrice"].Value.ToString();
                if (row.Cells["gvExpiryDate"].FormattedValue=="")
                {
                    dtExpiryDate.Value = DateTime.Now.Date;
                }
                else
                {
                    dtExpiryDate.Value = Convert.ToDateTime(row.Cells["gvExpiryDate"].Value.ToString());
                }
                
                ddCategory.SelectedValue = row.Cells["gvCatID"].Value.ToString();
               
                MainClass.Disable(panel5);
            }
        }
    }
}
