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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (validateControl())
            {
                tblUser tb = _db.tblUsers.Where(u => u.Username == Program.username && u.Password == txtOldPassword.Text).FirstOrDefault();
                if (tb != null)
                {
                    if (txtNewPassword.Text == txtConfirmNew.Text)
                    {
                        tb.Password = txtNewPassword.Text;
                        if (_db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Password Changed Successfully");
                            txtOldPassword.Text = "";
                            txtConfirmNew.Text = "";
                            txtNewPassword.Text = "";

                        }
                    }

                    else
                    {
                        MessageBox.Show("Password Mismatch");
                        txtConfirmNew.Text = "";
                        txtNewPassword.Text = "";
                        txtNewPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("You Entered Wrong Password");
                }
            }
           
        }
        public bool validateControl()
        {
            bool isvalid = true;
            if(txtOldPassword.Text=="")
            {
                MessageBox.Show("Enter Old Password");
                txtOldPassword.Text = "";
                txtOldPassword.Focus();
                return false;
              
            }
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Enter New Password");
                txtNewPassword.Text = "";
                txtNewPassword.Focus();
                return false;

            }
            return isvalid;
        }
    }
}
