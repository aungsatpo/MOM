using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;




namespace MOM
{
    public partial class AddLoan : Form
    {
        Loan_Manager loanMgr;
        Customer_Manager customerMgr;
        RATE_provider rateProvider;

        LOAN_provider loanProvider;
        CUSTOMER_provider customerProvider;

        List<Customer> customers;

        public AddLoan()
        {
            InitializeComponent();
            customerMgr = new Customer_Manager();
            loanMgr = new Loan_Manager();
            rateProvider = new RATE_provider();
            loanProvider = new LOAN_provider();
            customerProvider = new CUSTOMER_provider();

            customers = customerMgr.getAllCustomer();
            loadCustomer();
            txtLoanRate.Text = rateProvider.getCurrentRate().ToString();
        }

        public AddLoan(MOMDataSet.LOANRow row)
        {
            InitializeComponent();
            customerMgr = new Customer_Manager();
            loanMgr = new Loan_Manager();
            rateProvider = new RATE_provider();
            loanProvider = new LOAN_provider();
            customerProvider = new CUSTOMER_provider();

            //customers = customerMgr.getAllCustomer();
            //loadCustomer();
            customers = customerMgr.getAllCustomer();
            ddlCustomer.Items.Clear();
            ddlCustomer.Items.Add(customerProvider.getCustomerName(row.CUST_NO));
            ddlCustomer.SelectedIndex = 0;
            txtCustNo.Text = row.CUST_NO.ToString();

            txtLoanAmount.Text = row.LOAN_AMOUNT.ToString("C");
            txtLoanRate.Text = row.LOAN_RATE.ToString();
            dtpStartDate.Value = row.START_DATE;

            txtLoanAmount.ReadOnly = true;
            txtLoanRate.ReadOnly = true;
            dtpStartDate.Enabled = false;
            ddlCustomer.Enabled = false;
            btnNewCustomer.Enabled = false;
        }

        private void AddLoan_Load(object sender, EventArgs e)
        {
            
        }

        private void loadCustomer()
        {
            ddlCustomer.Items.Clear();
            foreach (Customer customer in customers)
            {
                ddlCustomer.Items.Add(customer.Cust_name);
            }
            ddlCustomer.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            string strItemName = txtItemName.Text.Trim();
            string strLoanAmount = txtLoanAmount.Text.Trim();
            string strLoanRate = txtLoanRate.Text.Trim();
            string strStartDate = dtpStartDate.Text;
            string strCustomerName = ddlCustomer.Text;
            string strRemarks = txtRemark.Text.Trim();

            if (strItemName == string.Empty || strItemName == null)
            {
                txtItemName.Focus();
            }
            else if (strLoanAmount == string.Empty || strLoanAmount == null)
            {
                txtLoanAmount.Focus();            
            }
            else if (strLoanRate == string.Empty || strLoanRate == null)
            {
                txtLoanRate.Focus();
            }
            else if (strCustomerName == string.Empty || strCustomerName == null)
            {
                ddlCustomer.Focus();
            }
            else
            {
                Loan loan = new Loan();
                loan.Item_name = strItemName;

                loan.Loan_amount = Decimal.Parse(strLoanAmount, NumberStyles.Currency, null);
                loan.Loan_rate = Double.Parse(strLoanRate);
                loan.Start_date = dtpStartDate.Value;
                loan.Cust_no = int.Parse(txtCustNo.Text);
                loan.Remarks = strRemarks;
                loan.Act_ind = "Y";
                loan.Create_dt = DateTime.Now;
                loan.Update_dt = DateTime.Now;
                
                string result = loanMgr.addLoan(loan);

                if (result.Equals(Messages.loan_add_success))
                {
                    MessageBox.Show(result + loanProvider.getLastLoanNo().ToString());
                    this.Close();
                }
                else MessageBox.Show(result);
            }
            Common.unlockButton(sender);
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCustomerName = ddlCustomer.SelectedItem.ToString();
            foreach (Customer customer in customers)
            {
                if (strCustomerName.Equals(customer.Cust_name))
                {
                    txtCustNo.Text = customer.Cust_no.ToString();                    
                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer f = new NewCustomer();
            f.ShowDialog();
            
            customers = customerMgr.getAllCustomer();
            loadCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoanAmount_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (Double.TryParse(txtLoanAmount.Text, NumberStyles.Currency, null, out amount))
            {
                txtLoanAmount.Text = amount.ToString("C");
            }
            else
            {
                txtLoanAmount.Text = "";
            }
        }
    }
}
