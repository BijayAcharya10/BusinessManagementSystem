using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Validatecontrol())
            {
                tblUser tb = _db.tblUsers.Where(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text).FirstOrDefault();
                if (tb != null)
                {
                    Program.username = txtUsername.Text;
                    Program.fullname = tb.Fullname;
                    if (cboUsertype.Text == "Admin")
                    {
                        MainForm frm = new MainForm();
                        frm.Show();
                        this.Hide();
                    }
                    else if (cboUsertype.Text == "User")
                    {
                        MainForm frm = new MainForm();
                        frm.adminToolStripMenuItem.Visible = false;
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboUsertype.SelectedIndex = 0;
        }
        public bool Validatecontrol()
        {
            bool isvalid = true;
            if (txtUsername.Text=="")
            {
                MessageBox.Show("Username Required");
                
                txtUsername.Focus();
                return false;

            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Required");

                txtPassword.Focus();
                return false;

            }
            if (cboUsertype.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Role");

               cboUsertype.Select();
                return false;

            }
            return isvalid;
        }
    }
  
}
