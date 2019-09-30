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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isvalid = ValidataControls();
            if (isvalid)
            {
                tblUser tbl = _db.tblUsers.Where(u => u.Username == txtUsername.Text).FirstOrDefault();
                if (tbl!=null)
                {
                    MessageBox.Show("Username Already Taken");

                }
                else
                {
                    tblUser tb = new tblUser();
                    tb.Username = txtUsername.Text;
                    tb.Password = txtPassword.Text;
                    tb.Usertype = cboUsertype.Text;
                    tb.Fullname = txtFullname.Text;
                    _db.tblUsers.Add(tb);
                    if (_db.SaveChanges() > 0)
                    {
                        ClearControls();
                        LoadGrid();
                        MessageBox.Show("User Created");
                    }
                }
            }

        }
        public bool ValidataControls()
        {
            bool isvalid = true;
            if (txtUsername.Text == "")
            {

                isvalid = false;
                MessageBox.Show("Username Required");
                txtUsername.Focus();
                return isvalid;

            }
            if (txtPassword.Text == "")
            {

                isvalid = false;
                MessageBox.Show("Password Required");
                txtPassword.Focus();
                return isvalid;
            }
            if (cboUsertype.SelectedIndex == 0)
            {

                isvalid = false;
                MessageBox.Show("Select Roles");
                cboUsertype.Select();
                return isvalid;
            }
            if (txtFullname.Text == "")
            {

                isvalid = false;
                MessageBox.Show("Fullname Required");
                txtFullname.Focus();
                return isvalid;
            }
            return isvalid;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadGrid()
        {
            var user = _db.tblUsers.ToList();
            dataGridView1.DataSource = user;
        }

        int userid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboUsertype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFullname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            tblUser tbl = _db.tblUsers.Where(u => u.UserId == userid).FirstOrDefault();
            tbl.Username = txtUsername.Text;
            tbl.Password = txtPassword.Text;
            tbl.Usertype = cboUsertype.Text;
            tbl.Fullname = txtFullname.Text;

            if (_db.SaveChanges() > 0)
            {
                LoadGrid();
                MessageBox.Show("User Updated");
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblUser tbl = _db.tblUsers.Where(u => u.UserId == userid).FirstOrDefault();
                if (_db.SaveChanges() > 0)
                {
                    LoadGrid();
                    MessageBox.Show("User Deleted");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            ClearControls();
        }

        private void ClearControls()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboUsertype.SelectedIndex = 0;
            txtFullname.Text = "";
            txtUsername.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<tblUser> lst = _db.tblUsers.Where(u => u.Username == txtSearch.Text).ToList();
            if (lst.Count > 0)
            {
                dataGridView1.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }
    }
}
