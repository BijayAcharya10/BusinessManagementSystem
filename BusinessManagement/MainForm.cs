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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ManageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory frm = new ManageCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageProduct frm = new ManageProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUnit frm = new ManageUnit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVendor frm = new ManageVendor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frm = new Purchase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VendorPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorPayment frm = new VendorPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CustomerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPayment frm = new CustomerPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void CascasdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void EmployeePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeSalaryPayment frm = new EmployeeSalaryPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void VenndorPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorPayment frm = new VendorPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CustomerPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerPayment frm = new CustomerPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Welcome: " + Program.fullname;
            var stocks = _db.tblStocks.Where(p => p.Quantity <= 5).Select(x => new { ProductName = x.tblProduct.ProductName, Quantity = x.Quantity }).ToList();
            dataGridView1.DataSource = stocks;


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void DatabaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupDatabase frm = new BackupDatabase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DatabaseRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreDatabase frm = new RestoreDatabase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport frm = new SalesReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PurchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReport frm = new PurchaseReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SalaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryReport frm = new SalaryReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void StockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport frm = new StockReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void VendorPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorPaymentReport frm = new VendorPaymentReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CustomerPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPaymentReport frm = new CustomerPaymentReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
