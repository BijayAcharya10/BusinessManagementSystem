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
    public partial class ManageVendor : Form
    {
        public ManageVendor()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblVendor tb = new tblVendor();
            tb.Name = txtName.Text;
            tb.Address = txtAddress.Text;
            tb.PhoneNo = txtPhoneNo.Text;
            tb.CompanyName = txtCompanyName.Text;
            tb.Email = txtEmail.Text;
            _db.tblVendors.Add(tb);
            if(_db.SaveChanges()>0)
            {
                LoadGrid();
                MessageBox.Show("Vendor Created");
            }
        }

        private void ManageVendor_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var vendors = _db.tblVendors.Select(x => new { VendorId = x.VendorId, VendorName = x.Name, Address = x.Address, PhoneNo = x.PhoneNo, CompanyName = x.CompanyName, Email = x.Email }).ToList();
            dataGridView1.DataSource = vendors;
        }
    }
}
