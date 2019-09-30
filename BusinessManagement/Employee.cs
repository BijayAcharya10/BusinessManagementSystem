using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities _db = new BusinessManagementDBEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblEmployee tb = new tblEmployee();
            tb.Name = txtName.Text;
            tb.Gender = rbdMale.Checked ? "Male" : "Female";
            tb.Email = txtEmail.Text;
            tb.Salary = Convert.ToDecimal(txtSalary.Text);
            tb.Position = cboPosition.Text;
            tb.PaymentType = cboPaymentType.Text;
            tb.IsActive = chkIsActive.Checked ? true : false;
            _db.tblEmployees.Add(tb);
            if(_db.SaveChanges()>0)
            {
                dataGridView1.DataSource = _db.tblEmployees.ToList();
                MessageBox.Show("Employee Created");
                cboPaymentType.SelectedIndex = 0;
                cboPosition.SelectedIndex = 0;
                txtEmail.Text = "";
                txtName.Text = "";
                txtSalary.Text = "";
                chkIsActive.Checked = false;
                rbdMale.Checked = true;
                txtName.Focus();
            }
          
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            cboPaymentType.SelectedIndex = 0;
            cboPosition.SelectedIndex = 0;
            dataGridView1.DataSource = _db.tblEmployees.ToList();
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length > 0 && txtEmail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Input Valid Email");
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            //https://www.c-sharpcorner.com/UploadFile/87b416/validating-user-input-with-regular-expressions/
            if (!Regex.Match(txtName.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // city was incorrect  
                MessageBox.Show("Invalid Name");
                txtEmail.SelectAll();
                e.Cancel = true;
            }// 
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var text = txtSalary.Text.Trim();
            //if (Regex.IsMatch(text, @"^\d{1,2}(\.\d{1,2})?$"))
            //{
                
            //    // Do something here
            //}
            //else
            //{
            //    MessageBox.Show("Invaid Salary");
              
              
            //}
        }
    }
    
}
