using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BusinessManagement
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void CboCategoryName_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadUnit();

            LoadGrid();
        }

        private void LoadGrid()
        {
            var lst = _db.tblProducts.Select(x => new { ProductId = x.ProductId, CategoryName = x.tblCategory.CategoryName, ProductNamme=x.ProductName, UnitName = x.tblUnit.UnitName, UnitPrice = x.UnitPrice, SellingPrice = x.SellingPrice }).ToList();
            dataGridView1.DataSource = lst;
        }

        private void LoadUnit()
        {
            List<tblUnit> lst = _db.tblUnits.ToList();
            tblUnit tbl = new tblUnit();
            tbl.UnitName = "Choose Unit";
            lst.Insert(0, tbl);
            cboUnit.DataSource = lst;
            cboUnit.DisplayMember = "UnitName";
            cboUnit.ValueMember = "UnitId";
            cboUnit.SelectedIndex = 0;
        }

        private void LoadCategory()
        {
            List<tblCategory> lst = _db.tblCategories.ToList();
            tblCategory tb = new tblCategory();
            tb.CategoryName = "Choose Category";
            lst.Insert(0, tb);
            cboCategory.DataSource = lst;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
            cboCategory.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblProduct tb = new tblProduct();
            tb.CategoryId =Convert.ToInt32( cboCategory.SelectedValue.ToString());
            tb.ProductName = txtProductName.Text;
            tb.UnitId = Convert.ToInt32(cboUnit.SelectedValue.ToString());
            tb.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            tb.SellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            _db.tblProducts.Add(tb);
            if(_db.SaveChanges()>0)
            {
                LoadGrid();
                MessageBox.Show("Product Created");
            }
           
        }

        int productid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            tblProduct tb = _db.tblProducts.Where(p => p.ProductId == productid).FirstOrDefault();
            cboCategory.SelectedValue = tb.CategoryId;
            cboUnit.SelectedValue = tb.UnitId;
            txtProductName.Text = tb.ProductName;
            txtUnitPrice.Text = tb.UnitPrice.ToString();
            txtSellingPrice.Text = tb.SellingPrice.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            tblProduct tb = _db.tblProducts.Where(p => p.ProductId == productid).FirstOrDefault();
            tb.CategoryId =Convert.ToInt32( cboCategory.SelectedValue);
            tb.UnitId =Convert.ToInt32( cboUnit.SelectedValue.ToString());
            tb.ProductName = txtProductName.Text;
            tb.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            tb.SellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            if (_db.SaveChanges() > 0)
            {
                LoadGrid();
                MessageBox.Show("Product Updated");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblProduct tb = _db.tblProducts.Where(p => p.ProductId == productid).FirstOrDefault();
                _db.tblProducts.Remove(tb);
                if (_db.SaveChanges() > 0)
                {
                    LoadGrid();
                    MessageBox.Show("Product Deleted");
                }
            }

        }
    }
}
