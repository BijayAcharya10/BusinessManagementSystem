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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void CustomerList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.tblCustomers.ToList();
        }
        public string customerid = "";
        public string customername = "";
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            customername = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
