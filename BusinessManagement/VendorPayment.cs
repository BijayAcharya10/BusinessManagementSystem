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
    public partial class VendorPayment : Form
    {
        public VendorPayment()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void VendorPayment_Load(object sender, EventArgs e)
        {
            cboPaymentMode.SelectedIndex = 0;
            List<tblVendor> vendors = _db.tblVendors.ToList();
          
            tblVendor tb = new tblVendor();
            tb.Name = "Choose Vendor";
            vendors.Insert(0,tb);
           cboVendor.DataSource = vendors;
            cboVendor.DisplayMember = "Name";
            cboVendor.ValueMember = "VendorId";
            cboVendor.SelectedIndex = 0;

        }

        private void CboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVendor.SelectedIndex!=0)
            {
                int vendorid = Convert.ToInt32(cboVendor.SelectedValue.ToString());
                var vendors = _db.tblVendorPayments.Select(x => new {VendorId=x.VendorId, VendorName = x.tblVendor.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(v=>v.VendorId== vendorid).ToList();
               
                dataGridView1.DataSource = vendors;

                var tbv = _db.tblVendorPayments.OrderByDescending(a => a.VendorPaymentId).Select(x => new { VendorId = x.VendorId, VendorName = x.tblVendor.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(b=>b.VendorId==vendorid).Take(1).FirstOrDefault();

                txtTotalAmount.Text = tbv.RemainingAmount.ToString();
            }
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtPaidAmount.Text.Length>0)
            {
                txtRemainingAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text)).ToString();
            }
            else
            {
                txtRemainingAmount.Text = "";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            tblVendorPayment tbv = new tblVendorPayment();
            tbv.VendorId = Convert.ToInt32(cboVendor.SelectedValue.ToString());
            tbv.PaymentDate = Convert.ToDateTime(dateTimePicker1.Value);
            tbv.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            tbv.PaymentAmount = Convert.ToDecimal(txtPaidAmount.Text);
            tbv.RemainingAmount = Convert.ToDecimal(txtRemainingAmount.Text);
            tbv.PaymentMode = cboPaymentMode.Text;
            _db.tblVendorPayments.Add(tbv);
            if(_db.SaveChanges()>0)
            {
                int vendorid = Convert.ToInt32(cboVendor.SelectedValue.ToString());
                var vendors = _db.tblVendorPayments.Select(x => new { VendorId = x.VendorId, VendorName = x.tblVendor.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(v => v.VendorId == vendorid).ToList();

                dataGridView1.DataSource = vendors;

                MessageBox.Show("Payment Done");
                cboVendor.SelectedIndex = 0;
                txtPaidAmount.Text = "";
                txtTotalAmount.Text = "";
                txtRemainingAmount.Text = "";
                cboPaymentMode.SelectedIndex = 0;
            }

        }
    }
}
