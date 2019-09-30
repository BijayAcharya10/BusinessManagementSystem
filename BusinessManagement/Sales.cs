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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        BusinessManagementDBEntities db = new BusinessManagementDBEntities();
        private void FrmSales_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCategory();
            txtInvoiceDate.Text = DateTime.Today.ToShortDateString();


            tblSalesInvoice pur = db.tblSalesInvoices.OrderByDescending(i => i.SalesInvoiceId).Take(1).FirstOrDefault();
            if (pur != null)
            {
                string[] invno = pur.InvoiceNo.Split('-');
                int maxno = Convert.ToInt32(invno[1]) + 1;
                txtInvoiceNo.Text = "SL-" + maxno;
            }
            else
            {
                txtInvoiceNo.Text = "SL-1";
            }
        }
        private void LoadCategory()
        {
            List<tblCategory> lst = db.tblCategories.ToList();
            tblCategory tb = new tblCategory();
            tb.CategoryName = "Choose Category";
            lst.Insert(0, tb);
            cboCategory.DataSource = lst;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
            cboCategory.SelectedIndex = 0;
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex != 0)
            {
                int categoryid = Convert.ToInt32(cboCategory.SelectedValue.ToString());
                List<tblProduct> lst = db.tblProducts.Where(x => x.CategoryId == categoryid).ToList();
                tblProduct tb = new tblProduct();
                tb.ProductName = "Choose Product";
                lst.Insert(0, tb);
                cboProductName.DataSource = lst;
                cboProductName.DisplayMember = "ProductName";
                cboProductName.ValueMember = "ProductId";
                cboProductName.SelectedIndex = 0;
            }
        }

        int unitid = 0;
        private void CboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductName.SelectedIndex != 0)
            {
                int productid = Convert.ToInt32(cboProductName.SelectedValue.ToString());
                var tb = db.tblProducts.Where(x => x.ProductId == productid).Select(x => new { UnitPrice = x.UnitPrice, UnitName = x.tblUnit.UnitName }).FirstOrDefault();
                txtUnitPrice.Text = tb.UnitPrice.ToString();

                txtProductUnit.Text = tb.UnitName;
            }
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0)
            {
                int productid = Convert.ToInt32(cboProductName.SelectedValue.ToString());
                tblStock tb = db.tblStocks.Where(p => p.ProductId == productid).FirstOrDefault();
                int quantity = Convert.ToInt32(txtQuantity.Text);
                if (tb.Quantity > quantity)
                {

                    if (txtUnitPrice.Text.Length > 0)
                    {
                        decimal rate = Convert.ToDecimal(0.15);
                        txtTotal.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToDecimal(txtUnitPrice.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Product");
                        cboProductName.Select();
                        txtQuantity.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("You Have Quantity #" + tb.Quantity + " " + " In Your Stock");
                }

            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {
            if (txtTax.Text.Length > 0)
            {
                txtTotal.Text = ((Convert.ToDecimal(txtTotal.Text) * (Convert.ToDecimal(txtTax.Text) / 100)) + Convert.ToDecimal(txtTotal.Text)).ToString();
            }
            else
            {
                txtTotal.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToDecimal(txtUnitPrice.Text)).ToString();
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int customerid = 0;
        private void TxtCustomerName_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCustomerName.Text = frm.customername;
                customerid = Convert.ToInt32(frm.customerid);
            }
        }

        int i = 0;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["colCategoryId"].Value = cboCategory.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colCategoryName"].Value = cboCategory.Text;
            dataGridView1.Rows[i].Cells["colProductId"].Value = cboProductName.SelectedValue.ToString();
            dataGridView1.Rows[i].Cells["colProductName"].Value = cboProductName.Text;
            dataGridView1.Rows[i].Cells["colUnit"].Value = txtProductUnit.Text;
            dataGridView1.Rows[i].Cells["colUnitId"].Value = unitid;
            dataGridView1.Rows[i].Cells["colUnitPrice"].Value = txtUnitPrice.Text;
            dataGridView1.Rows[i].Cells["colQuantity"].Value = txtQuantity.Text;
            dataGridView1.Rows[i].Cells["colTax"].Value = txtTax.Text;
            dataGridView1.Rows[i].Cells["colTotal"].Value = txtTotal.Text;
            i++;
            txtGrandTotal.Text = (Convert.ToDecimal(txtGrandTotal.Text) + Convert.ToDecimal(txtTotal.Text)).ToString();
        }

        private void TxtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblSalesInvoice tb = new tblSalesInvoice();
            tb.InvoiceNo = txtInvoiceNo.Text;
            tb.InvoiceDate = Convert.ToDateTime(txtInvoiceDate.Text);
            tb.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
            tb.CustomerId = customerid;
            db.tblSalesInvoices.Add(tb);
            db.SaveChanges();
            tblCustomerPayment tbvenpay = new tblCustomerPayment();
            tbvenpay.CustomerId = customerid;
            tbvenpay.PaymentDate = Convert.ToDateTime(txtInvoiceDate.Text);
            tbvenpay.TotalAmount = Convert.ToDecimal(txtGrandTotal.Text);
            tbvenpay.PaymentAmount = Convert.ToDecimal(txtPaidAmount.Text);
            tbvenpay.RemainingAmount = Convert.ToDecimal(txtRemainingAmount.Text);
           
            tbvenpay.PaymentMode = rbdCash.Checked ? "Cash" : "Cheque";
            db.tblCustomerPayments.Add(tbvenpay);

            if (db.SaveChanges() > 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    tblSale pur = new tblSale();
                    pur.SalesInvoiceId = tb.SalesInvoiceId;
                    pur.ProductId = Convert.ToInt32(dr.Cells["colProductId"].Value);

                    pur.Quantity = Convert.ToInt32(dr.Cells["colQuantity"].Value);
                    pur.UnitPrice = Convert.ToDecimal(dr.Cells["colUnitPrice"].Value);
                    pur.Total = Convert.ToDecimal(dr.Cells["colTotal"].Value);
                    pur.SalesDate = Convert.ToDateTime(txtInvoiceDate.Text);
                    pur.Tax = Convert.ToDecimal(dr.Cells["colTax"].Value);
                    db.tblSales.Add(pur);
                    if (db.SaveChanges() > 0)
                    {
                        tblStock tbst = db.tblStocks.Where(p => p.ProductId == pur.ProductId).FirstOrDefault();
                        if (tbst != null)
                        {
                            int puranoquantity = Convert.ToInt32(tbst.Quantity);
                            tbst.Quantity = puranoquantity - Convert.ToInt32(dr.Cells["colQuantity"].Value);
                            db.SaveChanges();

                        }
                       
                    }


                }
            }
            MessageBox.Show("Sales Done");
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text.Length > 0)
            {
                txtRemainingAmount.Text = (Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(txtPaidAmount.Text)).ToString();
            }
            else
            {
                txtRemainingAmount.Text = "";
            }
        }
    }
}
