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
    public partial class EmployeeSalaryPayment : Form
    {
        public EmployeeSalaryPayment()
        {
            InitializeComponent();
        }

        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void EmployeeSalaryPayment_Load(object sender, EventArgs e)
        {
            txtPaymentDate.Text = DateTime.Today.ToShortDateString();
            List<tblEmployee> lst = _db.tblEmployees.ToList();
            tblEmployee tb = new tblEmployee();
            tb.Name = "Choose Employee";
            lst.Insert(0, tb);
            cboEmployee.DataSource = lst;
            cboEmployee.DisplayMember = "Name";
            cboEmployee.ValueMember = "EmployeeId";
            cboEmployee.SelectedIndex = 0;
            
        }

        private void CboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmployee.SelectedIndex != 0)
            {
                int employeeid = Convert.ToInt32(cboEmployee.SelectedValue.ToString());
                tblEmployee tb = _db.tblEmployees.Where(b => b.EmployeeId == employeeid).FirstOrDefault();
                cboPaymentType.Text = tb.PaymentType;
                txtAmount.Text = tb.Salary.ToString();

                var employeepayment = _db.tblEmployeePayments.Where(p => p.EmployeeId == employeeid).Select(x => new { PaymentDate = x.PaymentDate, Amount = x.Amount }).ToList();
                dataGridView1.DataSource = employeepayment;
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure want to submit payment","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                int empid= Convert.ToInt32(cboEmployee.SelectedValue.ToString());
                DateTime paymentdate = Convert.ToDateTime(txtPaymentDate.Text);
                tblEmployeePayment pay = _db.tblEmployeePayments.Where(p => p.EmployeeId == empid && p.PaymentDate.Value.Month== paymentdate.Month).FirstOrDefault();
                if (pay != null)
                {
                    MessageBox.Show("Payment Already Done");
                }
                else
                {
                    tblEmployeePayment tb = new tblEmployeePayment();

                    tb.EmployeeId = Convert.ToInt32(cboEmployee.SelectedValue.ToString());
                    tb.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                    tb.Amount = Convert.ToDecimal(txtAmount.Text);
                    tb.PaymentBy = Program.fullname;
                    _db.tblEmployeePayments.Add(tb);
                    if (_db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Payment Done");
                        cboEmployee.SelectedIndex = 0;
                        cboPaymentType.SelectedIndex = 0;
                        txtAmount.Text = "";
                        txtPaymentDate.Text = DateTime.Today.ToShortDateString();
                        var employeepayment = _db.tblEmployeePayments.Where(p => p.EmployeeId == empid).Select(x => new { PaymentDate = x.PaymentDate, Amount = x.Amount }).ToList();
                        dataGridView1.DataSource = employeepayment;
                    }
                }
            }
        }
    }
}
