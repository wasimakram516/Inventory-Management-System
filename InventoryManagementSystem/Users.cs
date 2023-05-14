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
    public partial class Users : Sample2
    {
        int edit = 0;
        int UserID;
        Int16 stat;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (MainClass.con.State==ConnectionState.Open)
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
            if (txtName.Text == "") { lblName.Visible = true; } else { lblName.Visible = false; }
             if (txtUsername.Text == "") { lblUsername.Visible = true; } else { lblUsername.Visible = false; }
             if (txtPassword.Text == "") { lblPassword.Visible = true; } else { lblPassword.Visible = false; }
             if (txtPhone.Text == "") { lblPhone.Visible = true; } else { lblPhone.Visible = false; }
             if (txtEmail.Text == "") { lblEmail.Visible = true; } else { lblEmail.Visible = false; }
            if (ddStatus.SelectedIndex == -1) { lblStatus.Visible = true; }else { lblStatus.Visible = false; }

            if (lblName.Visible == true|| lblUsername.Visible == true|| lblPassword.Visible == true|| lblPhone.Visible == true|| lblEmail.Visible == true|| lblStatus.Visible==true)
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

                if (edit==0)//Code for save button
                {
                   
                    clsInsertion.InsertUsers(txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text,stat);
                    clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus);
                    MainClass.SNO(dataGridView1, "gvSNO");
                    MainClass.DisableReset(panel5);
                }

                else if(edit==1)//code for update button
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update " + txtName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr==DialogResult.Yes)
                    {
                        clsUpdation.UpdateUsers(UserID, txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text, stat);
                        clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus);
                        MainClass.SNO(dataGridView1, "gvSNO");
                        MainClass.DisableReset(panel5);
                    }
                   
                }
            }
           
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit==1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clsDeletion.delete(UserID, "stp_DeleteUser", "@UserID");
                    clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus);

                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus);
            MainClass.SNO(dataGridView1, "gvSNO");
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text!="")
            {
                clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus,txtSearch.Text);

            }
            else
            {
                clsSelection.SelectUsers(dataGridView1, gvUserID, gvName, gvUsername, gvPassword, gvPhone, gvEmail, gvStatus);

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "") { lblName.Visible = true; } else { lblName.Visible = false; }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { lblUsername.Visible = true; } else { lblUsername.Visible = false; }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { lblPassword.Visible = true; } else { lblPassword.Visible = false; }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "") { lblPhone.Visible = true; } else { lblPhone.Visible = false; }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") { lblEmail.Visible = true; } else { lblEmail.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID =Convert.ToInt32( row.Cells["gvUserID"].Value.ToString());
                txtName.Text = row.Cells["gvName"].Value.ToString();
                txtUsername.Text= row.Cells["gvUsername"].Value.ToString();
                txtPassword.Text = row.Cells["gvPassword"].Value.ToString();
                txtPhone.Text = row.Cells["gvPhone"].Value.ToString();
                txtEmail.Text = row.Cells["gvEmail"].Value.ToString();
                ddStatus.SelectedItem = row.Cells["gvStatus"].Value.ToString();
                MainClass.Disable(panel5);
            }
        }

        
    }
}
