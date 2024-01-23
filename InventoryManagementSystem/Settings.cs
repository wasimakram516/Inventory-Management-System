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
                txtUserID.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserID.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (chkISecurity.Checked)
            {
                txtUserID.Enabled = false;
                txtPassword.Enabled = false;
                if (txtDataSource.Text == "") { errServer.Visible = true; } else { errServer.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (errServer.Visible || errDatabase.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory!");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWin(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (txtDataSource.Text == "") { errServer.Visible = true; } else { errServer.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (txtUserID.Text == "") { errUserID.Visible = true; } else { errUserID.Visible = false; }
                if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
                if (errServer.Visible || errDatabase.Visible || errUserID.Visible || errPassword.Visible)
                {
                   MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUserID.Text + ";Password=" + txtPassword.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWin(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void lblTopUser_Click(object sender, EventArgs e)
        {

        }
    }
}
