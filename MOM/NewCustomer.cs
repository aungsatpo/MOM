using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;




namespace MOM
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text.Trim().Length < 1)
            {
                MessageBox.Show(Messages.customer_add_noname);
                txtCustName.Focus();
                return;
            }

            Common.lockButton(sender);

            Customer_Manager customerMgr = new Customer_Manager();
            Customer customer = new Customer();
            //customer.Cust_no = int.Parse(txtCustNo.Text);
            customer.Cust_name = txtCustName.Text.Trim();
            customer.Cust_phone = txtCustPhone.Text.Trim();
            customer.Cust_addr = txtCustAddr.Text.Trim();

            string result = customerMgr.addCustomer(customer);
            if (result.Equals(Messages.customer_add_success))
            {
                MessageBox.Show(Messages.customer_add_success);
                this.Close();
            }
            else MessageBox.Show(result);

            Common.unlockButton(sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
