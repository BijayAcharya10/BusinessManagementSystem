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
    public partial class VendorList : Form
    {
        public VendorList()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void VendorList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            var vendors = _db.tblVendors.Select(x => new { VendorId = x.VendorId, VendorName = x.Name, Address = x.Address, PhoneNo = x.PhoneNo, CompanyName = x.CompanyName, Email = x.Email }).ToList();
            dataGridView1.DataSource = vendors;
        }

        public string vendorid = "";
        public string vendorname = "";
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vendorid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vendorname= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
