using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;



using MOM.Reports;

namespace MOM
{
    public partial class Report : Form
    {
        Loan_Manager loanMgr;
        Customer_Manager customerMgr;
        RATE_provider rateProvider;

        LOAN_provider loanProvider;

        public Report()
        {
            InitializeComponent();
            customerMgr = new Customer_Manager();
            loanMgr = new Loan_Manager();
            rateProvider = new RATE_provider();
            loanProvider = new LOAN_provider();
        }






        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            GeneralReport f = new GeneralReport(DateTime.Parse(dtpFrom.Value.ToShortDateString()), DateTime.Parse(dtpTo.Value.AddDays(1).ToShortDateString()));
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.loadMonthlyYears();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            if (!string.IsNullOrEmpty(ddlYear.Text))
            {
                MonthlyReport f = new MonthlyReport(ddlYear.Text);
                f.ShowDialog();
            }
            Common.unlockButton(sender);
        }

        private void loadMonthlyYears()
        {
            this.monthlY_YEARSTableAdapter1.Fill(this.ReportDataSet.MONTHLY_YEARS);

        }

        private void LOAN_CUSTOMERBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            YearlyReport f = new YearlyReport();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            PendingCollectionReport f = new PendingCollectionReport();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            UnpaidReport f = new UnpaidReport();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

    }
}
