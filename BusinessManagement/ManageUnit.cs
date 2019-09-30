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
    public partial class ManageUnit : Form
    {
        public ManageUnit()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblUnit tb = new tblUnit();
            tb.UnitName = txtCategoryName.Text;
           
            _db.tblUnits.Add(tb);
            if(_db.SaveChanges()>0)
            {
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
                LoadGrid();
                MessageBox.Show("Unit created");
            }
        }

        private void ManageUnit_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridView1.DataSource = _db.tblUnits.Select(x => new { UnitId = x.UnitId, UnitName = x.UnitName }).ToList();
        }
    }
}
