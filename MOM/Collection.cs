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
    public partial class Collection : Form
    {
        Loan_Manager loanMgr;
        Customer_Manager customerMgr;
        RATE_provider rateProvider;
        LOAN_provider loanProvider;

        CUSTOMER_provider customerProvider;

        MOMDataSet.LOANRow row;

        long loanNo;
        private string originalTotalInterest = "";
        private decimal originalLoanAmount = 0.00M;

        public Collection(long p1)
        {
            InitializeComponent();
            loanNo = p1;
            customerMgr = new Customer_Manager();
            loanMgr = new Loan_Manager();
            rateProvider = new RATE_provider();
            loanProvider = new LOAN_provider();
            customerProvider = new CUSTOMER_provider();

            row = loanProvider.getLoanByLoanNo(loanNo);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text)) return;
            if (isWrongDate()) return;

            string strEndDate = dtpEndDate.Value.ToShortDateString();
            decimal totalInterest = Decimal.Parse(txtTotalInterest.Text, NumberStyles.Currency, null);
            decimal collectLoanAmount = Decimal.Parse(txtLoanAmount.Text, NumberStyles.Currency, null);

            if (MessageBox.Show("Are you sure you want to collect?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //check partial or full payment
                if (collectLoanAmount > originalLoanAmount)
                {
                    MessageBox.Show(Messages.loan_partial_collect_invalid_amount);
                    return;
                }
                else if (collectLoanAmount < originalLoanAmount) //partial payment
                {
                    string result = loanProvider.partialCollectLoan(row.LOAN_NO, txtItemName.Text, collectLoanAmount, DateTime.Parse(strEndDate), totalInterest);

                    if (result.Equals(Messages.loan_partial_collect_success))
                    {
                        MessageBox.Show(result + row.LOAN_NO);

                        MOMDataSet.LOANRow newRow = row;
                        newRow.LOAN_AMOUNT = originalLoanAmount - collectLoanAmount;
                        AddLoan f = new AddLoan(newRow);
                        f.ShowDialog();
                        this.Close();

                        //string addResult = loanProvider.partialAddLoan(row, (originalLoanAmount - collectLoanAmount));

                        //if (addResult.Equals(Messages.loan_add_success))
                        //{
                        //    MessageBox.Show(addResult + loanProvider.getLastLoanNo().ToString());
                        //    this.Close();
                        //}
                        //else
                        //    MessageBox.Show(addResult);
                        
                    }
                    else MessageBox.Show(result);
                }
                else //full payment
                {
                    string result = loanProvider.collectLoan(row.LOAN_NO, txtItemName.Text, DateTime.Parse(strEndDate), totalInterest);

                    if (result.Equals(Messages.loan_collect_success))
                    {
                        MessageBox.Show(result);
                        this.Close();
                    }
                    else MessageBox.Show(result);
                }
            }
        }

        private void Collection_Load(object sender, EventArgs e)
        {
            Boolean collected = false;
            Boolean unpaid = false;

            try
            {
                if ((row.END_DATE == null || string.IsNullOrEmpty(row.END_DATE.ToString())) && row.ACT_IND.Equals("Y"))
                    collected = false;
                else
                    collected = true;
            }
            catch (StrongTypingException)
            {
                collected = false;
            }

            try
            {
                if (row.ACT_IND.Equals("Y"))
                    unpaid = false;
                else
                    unpaid = true;
            }
            catch (Exception)
            {
                unpaid = false;
            }
            

            txtLoanNumber.Text = row.LOAN_NO.ToString();
            txtItemName.Text = row.ITEM_NAME;
            txtLoanAmount.Text = row.LOAN_AMOUNT.ToString("C");
            originalLoanAmount = row.LOAN_AMOUNT;
            txtLoanRate.Text = row.LOAN_RATE.ToString();
            txtStartDate.Text = row.START_DATE.ToLongDateString();
            txtCustomer.Text = customerProvider.getCustomerName(row.CUST_NO);
            txtRemark.Text = row.REMARKS;

            if (collected)
            {
                btnCollect.Enabled = false;
                btnUnpaid.Enabled = false;
                dtpEndDate.Value = row.END_DATE;
                dtpEndDate.Enabled = false;
                txtTotalInterest.Text = row.INTEREST.ToString();
                txtTotalInterest.ReadOnly = true;
            }

            lblTotalDays.Text = refreshTotalDays();

            if (unpaid)
            {
                btnCollect.Enabled = false;
                btnUnpaid.Enabled = false;
                dtpEndDate.Value = row.START_DATE;
                dtpEndDate.Enabled = false;
                txtTotalInterest.ReadOnly = true;
                lblTotalDays.ForeColor = Color.Red;
                lblTotalDays.Text = "This Loan was unpaid.";
            }
            
            

            if (collected)
                txtTotalInterest.Text = row.INTEREST.ToString("C");
            else if (unpaid)
                txtTotalInterest.Text = new decimal(0.00d).ToString("C");
            else
                txtTotalInterest.Text = Common.calculateInterest(row.START_DATE, dtpEndDate.Value, row.LOAN_AMOUNT, row.LOAN_RATE).ToString("C");
            

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            isWrongDate();
            lblTotalDays.Text = refreshTotalDays();
            txtTotalInterest.Text = Common.calculateInterest(row.START_DATE, dtpEndDate.Value, Decimal.Parse(txtLoanAmount.Text, NumberStyles.Currency, null), row.LOAN_RATE).ToString("C");
        }

        private string refreshTotalDays()
        {
            double totalDays = Common.getTotalDays(row.START_DATE, dtpEndDate.Value);

            if (totalDays > 30)
            {
                int month = (int) totalDays / 30;
                int days = (int) totalDays % 30;
                return "For " + month.ToString() + " months and " + days.ToString() + " days";
            }
            else
            {
                return "For " + totalDays.ToString() + " days";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = loanProvider.deleteLoan(row.LOAN_NO);

                if (result.Equals(Messages.loan_delete_success))
                {
                    MessageBox.Show(result);
                    this.Close();
                }
                else MessageBox.Show(result);
            }
        }

        private Boolean isWrongDate()
        {
            if (row.START_DATE > dtpEndDate.Value)
            {
                MessageBox.Show("End date must be later than Start date");
                dtpEndDate.Value = DateTime.Now;
                return true;
            }
            return false;
        }

        private void txtTotalInterest_Leave(object sender, EventArgs e)
        {
            decimal amount = 0.0M;
            
            if (decimal.TryParse(txtTotalInterest.Text, NumberStyles.Currency, null, out amount))
            {
                txtTotalInterest.Text = amount.ToString("C");
            }
            else
            {
                txtTotalInterest.Text = originalTotalInterest;
            }
        }

        private void txtTotalInterest_Enter(object sender, EventArgs e)
        {
            originalTotalInterest = txtTotalInterest.Text;
        }

        private void btnUncollect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to unpaid this Loan?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = loanProvider.uncollectLoan(row.LOAN_NO);

                if (result.Equals(Messages.loan_uncollect_success))
                {
                    MessageBox.Show(result);
                    this.Close();
                }
                else MessageBox.Show(result);
            }
        }

        private void txtLoanAmount_Leave(object sender, EventArgs e)
        {
            decimal amount = 0.0M;

            if (decimal.TryParse(txtLoanAmount.Text, NumberStyles.Currency, null, out amount))
            {
                txtLoanAmount.Text = amount.ToString("C");
            }
            else
            {
                txtLoanAmount.Text = originalLoanAmount.ToString("C");
            }

            if (Decimal.Parse(txtLoanAmount.Text, NumberStyles.Currency, null) != originalLoanAmount)
            {
                txtItemName.ReadOnly = false;
            }

            txtTotalInterest.Text = Common.calculateInterest(row.START_DATE, dtpEndDate.Value, Decimal.Parse(txtLoanAmount.Text, NumberStyles.Currency, null), row.LOAN_RATE).ToString("C");
        }
    }
}
