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
    public partial class CustomerPayment : Form
    {
        public CustomerPayment()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            cboPaymentMode.SelectedIndex = 0;
            List<tblCustomer> customers = _db.tblCustomers.ToList();

            tblCustomer tb = new tblCustomer();
            tb.Name = "Choose Customer";
            customers.Insert(0, tb);
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustomerId";
            cboCustomer.SelectedIndex = 0;
        }

        private void CboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex != 0)
            {
                int customerid = Convert.ToInt32(cboCustomer.SelectedValue.ToString());
                var customer = _db.tblCustomerPayments.Select(x => new { CustomerID = x.CustomerId, CustomerName = x.tblCustomer.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(v => v.CustomerID == customerid).ToList();

                dataGridView1.DataSource = customer;

                var tbv = _db.tblCustomerPayments.OrderByDescending(a => a.CustomerPaymentId).Select(x => new { CustomerId = x.CustomerId, CustomerName = x.tblCustomer.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(b => b.CustomerId == customerid).Take(1).FirstOrDefault();

                txtTotalAmount.Text = tbv.RemainingAmount.ToString();
            }
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text.Length > 0)
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
            tblCustomerPayment tbv = new tblCustomerPayment();
            tbv.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue.ToString());
            tbv.PaymentDate = Convert.ToDateTime(dateTimePicker1.Value);
            tbv.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            tbv.PaymentAmount = Convert.ToDecimal(txtPaidAmount.Text);
            tbv.RemainingAmount = Convert.ToDecimal(txtRemainingAmount.Text);
            tbv.PaymentMode = cboPaymentMode.Text;
            _db.tblCustomerPayments.Add(tbv);
            if (_db.SaveChanges() > 0)
            {
                int customerid = Convert.ToInt32(cboCustomer.SelectedValue.ToString());
                var vendors = _db.tblCustomerPayments.Select(x => new { CustomerId = x.CustomerId, CustomerName = x.tblCustomer.Name, PaymentDate = x.PaymentDate, TotalAmount = x.TotalAmount, PaymentAmount = x.PaymentAmount, RemainingAmount = x.RemainingAmount }).Where(v => v.CustomerId == customerid).ToList();

                dataGridView1.DataSource = vendors;

                MessageBox.Show("Payment Done");
                cboCustomer.SelectedIndex = 0;
                txtPaidAmount.Text = "";
                txtTotalAmount.Text = "";
                txtRemainingAmount.Text = "";
                cboPaymentMode.SelectedIndex = 0;
            }

        }

        private void TxtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
