using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MOM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            NewCustomer f = new NewCustomer();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            EditCustomer f = new EditCustomer();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            AddLoan f = new AddLoan();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            NewRate f = new NewRate();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnSearchLoan_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            SearchLoan f = new SearchLoan();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnUncollected_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            PendingCollection f = new PendingCollection();
            f.ShowDialog();
            Common.unlockButton(sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Common.lockButton(sender);
            Report f = new Report();
            f.ShowDialog();
            Common.unlockButton(sender);
        }
    }
}
