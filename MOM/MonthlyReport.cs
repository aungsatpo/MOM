using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOM.Reports
{
    public partial class MonthlyReport : Form
    {
        int year;
        public MonthlyReport(string year)
        {
            InitializeComponent();
            this.year = int.Parse(year);
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDataSet.MONTHLY' table. You can move, or remove it, as needed.
            this.MONTHLYTableAdapter.Fill(this.ReportDataSet.MONTHLY, this.year);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
