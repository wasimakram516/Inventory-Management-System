using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    class MainClass
    {
        public MainClass()
        {

        }
        //Function to read folder path
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string conn = "";
        public static string ConStr()
        {
            if (File.Exists(path + "\\connect"))
            {
                conn = File.ReadAllText(path + "\\connect");
            }
            else
            {
                Settings obj = new Settings();
                obj.MdiParent = MDI.ActiveForm;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            return conn;
        }

        public static SqlConnection con = new SqlConnection(ConStr());
        public static void SNO(DataGridView gv, string columnName)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[columnName].Value = count;
            }
        }
        public static void ShowWin(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void ShowWin(Form openWin, Form MDI)
        {

            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static DialogResult ShowMsg(string message, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DisableReset(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }

            }
        }

        public static void Disable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;

                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;

                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;

                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;

                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;

                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }
            }
        }

        public static void EnableReset(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
            }
        }

        public static void Enable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;

                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;

                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;

                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;

                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;

                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
            }
        }

        public static void EnableReset(GroupBox gb)
        {
            foreach (Control ctr in gb.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
            }
        }

        public static void DisableReset(GroupBox gb)
        {
            foreach (Control ctr in gb.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }

            }
        }
    }
}
