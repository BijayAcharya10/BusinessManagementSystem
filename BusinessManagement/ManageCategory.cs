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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void ManageCategory_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridView1.DataSource = _db.tblCategories.Select(x => new { CategoryId = x.CategoryId, CategoryName = x.CategoryName }).ToList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblCategory tb = new tblCategory();
            tb.CategoryName = txtCategoryName.Text;
            _db.tblCategories.Add(tb);
            if(_db.SaveChanges()>0)
            {
                LoadGrid();
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
                MessageBox.Show("Category Created");
            }
        }

        int categoryid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            txtCategoryName.Text = "";
            txtCategoryName.Focus();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            tblCategory tb = _db.tblCategories.Where(c => c.CategoryId == categoryid).FirstOrDefault();
            tb.CategoryName = txtCategoryName.Text;
            if (_db.SaveChanges() > 0)
            {
                LoadGrid();
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
                MessageBox.Show("Category Updated");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure want to delete?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                tblCategory tb = _db.tblCategories.Where(c => c.CategoryId == categoryid).FirstOrDefault();
                _db.tblCategories.Remove(tb);
                if (_db.SaveChanges() > 0)
                {
                    LoadGrid();
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                    MessageBox.Show("Category Deleted");
                }

            }
        }
    }
}
