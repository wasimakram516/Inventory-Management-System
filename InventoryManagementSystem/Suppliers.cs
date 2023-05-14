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
    public partial class Suppliers : Sample2
    {
        int edit = 0;
        int supplierID;
        Int16 stat;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }
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
            if (txtSupplierName.Text == "") { errSupplier.Visible = true; } else { errSupplier.Visible = false; }
            if (txtContactName.Text == "") { errContactPerson.Visible = true; } else { errContactPerson.Visible = false; }
            if (txtPhone1.Text == "") { errPhone.Visible = true; } else { errPhone.Visible = false; }
            if (txtAddress.Text == "") { erraddress.Visible = true; } else { erraddress.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }

            if (errSupplier.Visible == true || errContactPerson.Visible == true || errPhone.Visible == true || erraddress.Visible == true || errStatus.Visible == true)
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

                if (edit == 0)//Code for save button
                {
                    if (txtPhone2.Text == "" && txtNTN.Text == "")
                    {
                        clsInsertion.InsertSuppliers(txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, null, null);
                    }

                    else if (txtPhone2.Text != "" && txtNTN.Text == "")
                    {
                        clsInsertion.InsertSuppliers(txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, txtPhone2.Text, null);
                    }

                    else if (txtPhone2.Text == "" && txtNTN.Text != "")
                    {
                        clsInsertion.InsertSuppliers(txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, null, txtNTN.Text);
                    }

                    else
                    {
                        clsInsertion.InsertSuppliers(txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, txtPhone2.Text, txtNTN.Text);
                    }

                    clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    MainClass.DisableReset(panel5);
                }

                else if (edit == 1)//code for update button
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update " + txtSupplierName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (txtPhone2.Text == "" && txtNTN.Text == "")
                        {
                            clsUpdation.UpdateSuppliers(supplierID, txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, null, null);
                        }

                        else if (txtPhone2.Text != "" && txtNTN.Text == "")
                        {
                            clsUpdation.UpdateSuppliers(supplierID, txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, txtPhone2.Text, null);
                        }

                        else if (txtPhone2.Text == "" && txtNTN.Text != "")
                        {
                            clsUpdation.UpdateSuppliers(supplierID, txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, null, txtNTN.Text);
                        }

                        else
                        {
                            clsUpdation.UpdateSuppliers(supplierID, txtSupplierName.Text, txtContactName.Text, txtPhone1.Text, txtAddress.Text, stat, txtPhone2.Text, txtNTN.Text);
                        }
                        clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus);
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
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtSupplierName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.delete(supplierID, "stp_DeleteSuppliers", "@SupID");
                    clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus, txtSearch.Text);
            }
            else
            {
                clsSelection.SelectSuppliers(dataGridView1, gvSupID, gvCompanyName, gvContactPerson, gvPhone1, gvPhone2, gvNTN, gvAddress, gvStatus);
            }
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "") { errSupplier.Visible = true; } else { errSupplier.Visible = false; }

        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {
            if (txtContactName.Text == "") { errContactPerson.Visible = true; } else { errContactPerson.Visible = false; }

        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone1.Text == "") { errPhone.Visible = true; } else { errPhone.Visible = false; }

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") { erraddress.Visible = true; } else { erraddress.Visible = false; }

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
                supplierID = Convert.ToInt32(row.Cells["gvSupID"].Value.ToString());
                txtSupplierName.Text = row.Cells["gvCompanyName"].Value.ToString();
                txtContactName.Text = row.Cells["gvContactPerson"].Value.ToString();
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
                txtNTN.Text = row.Cells["gvNTN"].Value.ToString();
                txtAddress.Text = row.Cells["gvAddress"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                MainClass.Disable(panel5);
            }
        }
    }
}
