using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void chkISecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkISecurity.Checked)
            {
                txtUserID.Text = "";
                txtUserID.Visible = false;
                lblUserID.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Text = "";
                txtPassword.Visible = false;
            }
            else
            {
                lblUserID.Visible = true;
                lblPassword.Visible = true;
                txtUserID.Visible = true;
                txtPassword.Visible = true;
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (chkISecurity.Checked)
            {
                //if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                //if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                //if (errDataSource.Visible || errDatabase.Visible)
                //{
                //    MessageBox.Show("Fields with * are mandatory!");
                //}
                //else
                //{
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWin(log, this, MDI.ActiveForm);
                    }
               // }
            }
            else
            {
                //if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                //if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                //if (txtUsername.Text == "") { errUsername.Visible = true; } else { errUsername.Visible = false; }
                //if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
                //if (errDataSource.Visible || errDatabase.Visible || errUsername.Visible || errPassword.Visible)
                //{
                //    MessageBox.Show("Fields with * are mandatory!");
                //}
                //else
                //{
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUserID.Text + ";Password=" + txtPassword.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWin(log, this, MDI.ActiveForm);
                    }
                //}
            }
        }

        private void lblTopUser_Click(object sender, EventArgs e)
        {

        }
    }
}
