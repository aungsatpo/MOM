using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOM.Reports
{
    public partial class YearlyReport : Form
    {
        public YearlyReport()
        {
            InitializeComponent();
        }

        private void YearlyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDataSet.YEARLY' table. You can move, or remove it, as needed.
            this.YEARLYTableAdapter.Fill(this.ReportDataSet.YEARLY);
            this.reportViewer1.RefreshReport();
        }
    }
}
