using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace MOM
{
    public partial class PendingCollection : Form
    {
        public PendingCollection()
        {
            InitializeComponent();
        }

        private void Uncollected_Load(object sender, EventArgs e)
        {
            refreshPendingCollection();
        }

        private void dgvUncollected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void dgvUncollected_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }



        private void refreshPendingCollection()
        {
            dgvUncollected.DataSource = uncollecteD_LOANTableAdapter1.getUncollected();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUncollected_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            long l = (long)dgvUncollected.Rows[e.RowIndex].Cells["LOAN_NO"].Value;
            if (l < 0) return;
            Collection f = new Collection(l);
            f.ShowDialog();
            refreshPendingCollection();
        }

    }
}
