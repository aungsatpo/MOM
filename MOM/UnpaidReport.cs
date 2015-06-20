using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOM
{
    public partial class UnpaidReport : Form
    {
        public UnpaidReport()
        {
            InitializeComponent();
        }

        private void UnpaidReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDataSet.UNPAID' table. You can move, or remove it, as needed.
            this.UNPAIDTableAdapter.Fill(this.ReportDataSet.UNPAID);
            this.reportViewer1.RefreshReport();
        }
    }
}
