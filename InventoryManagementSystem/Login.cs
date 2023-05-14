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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (MainClass.con.State==ConnectionState.Open)
            {
                MainClass.con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { errUsername.Visible = true; } else { errUsername.Visible = false; }
            if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
            if (errUsername.Visible || errPassword.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {

                if (clsSelection.UserLogin(txtUsername.Text, txtPassword.Text))
                {
                    HomeScreen home = new InventoryManagementSystem.HomeScreen();
                    MainClass.ShowWin(home, this, MDI.ActiveForm);

                }

                else
                {
                    MainClass.ShowMsg("Invalid login Details.", "Error", "Error");
                }
            }

            //HomeScreen home = new InventoryManagementSystem.HomeScreen();
            //MainClass.ShowWin(home, this, MDI.ActiveForm);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { errUsername.Visible = true; } else { errUsername.Visible = false; }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
        }

       
    }
}
