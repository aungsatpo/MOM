using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOM
{
    public partial class PendingCollectionReport : Form
    {
        public PendingCollectionReport()
        {
            InitializeComponent();
        }

        private void PendingCollectionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDataSet.PENDING' table. You can move, or remove it, as needed.
            this.PENDINGTableAdapter.Fill(this.ReportDataSet.PENDING);
            this.reportViewer1.RefreshReport();
        }
    }
}
