using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;





namespace MOM
{
    public partial class SearchLoan : Form
    {
        Loan_Manager loanMgr;
        Customer_Manager customerMgr;
        RATE_provider rateProvider;

        LOAN_provider loanProvider;

        List<Customer> customers;

        public SearchLoan()
        {
            InitializeComponent();
            customerMgr = new Customer_Manager();
            loanMgr = new Loan_Manager();
            rateProvider = new RATE_provider();
            loanProvider = new LOAN_provider();
        }

        private void loadCustomer()
        {
            ddlCustomer.Items.Clear();
            customers = customerMgr.getAllCustomer();
            foreach (Customer customer in customers)
            {
                ddlCustomer.Items.Add(customer.Cust_name);
            }
            ddlCustomer.Text = "";
        }

        private void FindLoan_Load(object sender, EventArgs e)
        {
            loadCustomer();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            searchRecord();
            Common.unlockButton(sender);
        }

        private void searchRecord()
        {
            string strLoanNumber = txtLoanNumber.Text;
            string strCustNo = txtCustNo.Text;
            if (String.IsNullOrEmpty(strLoanNumber)) strLoanNumber = "0";
            if (String.IsNullOrEmpty(strCustNo)) strCustNo = "0";

            MOMDataSet.LOAN_CUSTOMERDataTable table = loaN_CUSTOMERTableAdapter1.getLoanBySearch(long.Parse(strLoanNumber), long.Parse(strCustNo), dtpStartDate.Value);
            dgvResult.DataSource = table;
        }

        private void dgvResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            long l = (long)dgvResult.Rows[e.RowIndex].Cells["LOAN_NO"].Value;
            if (l < 0) return;
            Collection f = new Collection(l);
            f.ShowDialog();
            searchRecord();
        }
    }
}
