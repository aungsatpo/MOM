using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;




namespace MOM
{
    public partial class NewRate : Form
    {
        private string globalText;

        public NewRate()
        {
            InitializeComponent();
            globalText = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtNewRate.Text.Trim()))
            {
                txtNewRate.Focus();
                return;
            }

            Common.lockButton(sender);


            Rate_Manager rateMgr = new Rate_Manager();
            Rate rate = new Rate();
            //customer.Cust_no = int.Parse(txtCustNo.Text);
            rate.Rate_rate = Convert.ToDecimal(txtNewRate.Text);
            rate.Remarks = txtRemarks.Text;
            rate.Rate_date = DateTime.Now;
            rate.Create_dt = DateTime.Now;
            rate.Update_dt = DateTime.Now;
            int i = rateMgr.addRate(rate);

            if (i == 1)
            {
                MessageBox.Show("Success");
                this.Close();
            }
            else MessageBox.Show("Fail");

            Common.unlockButton(sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewRate_Load(object sender, EventArgs e)
        {
            RATE_provider rateProvider = new RATE_provider();
            txtCurrentRate.Text = rateProvider.getCurrentRate().ToString();
        }

        private void firstLoad()
        {
            decimal decCurrentRate = 0.0M;
            MOM.MOMDataSetTableAdapters.RATETableAdapter rateAdapter = new MOM.MOMDataSetTableAdapters.RATETableAdapter();
            MOMDataSet.RATEDataTable rateTable = rateAdapter.getAllRates();
            foreach (MOMDataSet.RATERow row in rateTable.Rows)
            {
                decCurrentRate = row.RATE_RATE;
            }

            txtCurrentRate.Text = decCurrentRate.ToString();
        }

        private void txtNewRate_TextChanged(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(txtNewRate.Text, out d))
                globalText = txtNewRate.Text;
            else
            {
                txtNewRate.Text = globalText;
            }
        }
    }
}
