using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MOM.Reports
{
    public partial class GeneralReport : Form
    {
        private DateTime from, to;
        public GeneralReport(DateTime from, DateTime to)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
        }

        private void GeneralReport_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'ReportDataSet.LOAN_CUSTOMER' table. You can move, or remove it, as needed.
            this.GENERALTableAdapter.Fill(this.ReportDataSet.GENERAL, from, to);
            

            //ReportDataSet.LOAN_CUSTOMERDataTable dataTable = new ReportDataSet.LOAN_CUSTOMERDataTable();

            //foreach (ReportDataSet.LOAN_CUSTOMERRow row in this.ReportDataSet.LOAN_CUSTOMER.Rows)
            //{
            //    row.START_DATE = DateTime.Parse(row.START_DATE.ToShortDateString());
            //    //row.END_DATE = DateTime.Parse(row.END_DATE.ToShortDateString());

            //    dataTable.AddLOAN_CUSTOMERRow(row);
            //}

            
            this.reportViewer1.RefreshReport();

        }
    }
}
