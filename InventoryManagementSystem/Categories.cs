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
    public partial class Categories : Sample2
    {
        int edit;
        int CatID;
        Int16 stat;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.DisableReset(panel5);
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
            if (txtCategoryName.Text == "") { errCatName.Visible = true; } else { errCatName.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }

            if (errCatName.Visible==true||errStatus.Visible==true)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (ddStatus.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else
                {
                    stat = 0;
                }

                if (edit==0)///code for add operation
                {
                    clsInsertion.InsertCategories(txtCategoryName.Text, stat);
                    clsSelection.SelectCategories(dataGridView1, gvCatID, gvName, gvStatus);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    MainClass.DisableReset(panel5);
                }
                else // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update " + txtCategoryName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        clsUpdation.UpdateCategories(CatID, txtCategoryName.Text, stat);
                        clsSelection.SelectCategories(dataGridView1, gvCatID, gvName, gvStatus);
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
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtCategoryName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.delete(CatID, "stp_DeleteCat", "@CatID");
                    clsSelection.SelectCategories(dataGridView1, gvCatID, gvName, gvStatus);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            clsSelection.SelectCategories(dataGridView1, gvCatID, gvName, gvStatus);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectCategories(dataGridView1, gvCatID, gvName,gvStatus, txtSearch.Text);

            }
            else
            {
                clsSelection.SelectCategories(dataGridView1, gvCatID, gvName, gvStatus);

            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "") { errCatName.Visible = true; }else { errCatName.Visible = false; }
        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CatID = Convert.ToInt32(row.Cells["gvCatID"].Value.ToString());
                txtCategoryName.Text = row.Cells["gvName"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                MainClass.Disable(panel5);
            }
        }
    }
}
