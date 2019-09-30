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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblCustomer tb = new tblCustomer();
            tb.Name = txtName.Text;
            tb.Address = txtAddress.Text;
            tb.Phone = txtPhoneNo.Text;
            tb.CompanyName = txtCompanyName.Text;
            tb.Email = txtEmail.Text;
            _db.tblCustomers.Add(tb);
            if (_db.SaveChanges() > 0)
            {
                LoadGrid();
                MessageBox.Show("Customer Created");
            }
        }

        private void LoadGrid()
        {
            var vendors = _db.tblCustomers.Select(x => new { CustomerId = x.CustomerId, CustomerName = x.Name, Address = x.Address, PhoneNo = x.Phone, CompanyName = x.CompanyName, Email = x.Email }).ToList();
            dataGridView1.DataSource = vendors;
        }
        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
