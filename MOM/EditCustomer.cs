using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;




namespace MOM
{
    public partial class EditCustomer : Form
    {
        Customer_Manager customerMgr;

        CUSTOMER_provider customerProvider;
        
        List<Customer> customers;

        public EditCustomer()
        {
            InitializeComponent();
            customerMgr = new Customer_Manager();
            customerProvider = new CUSTOMER_provider();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            customers = customerMgr.getAllCustomer();
            loadDDL();
        }

        private void loadDDL()
        {
            ddlOld.Items.Clear();
            foreach (Customer customer in customers)
            {
                ddlOld.Items.Add(customer.Cust_name);
            }
            ddlOld.Text = "";
        }

        private void reload()
        {
            customerMgr = new Customer_Manager();
            customers = customerMgr.getAllCustomer();
            loadDDL();
            txtCustNo.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtCustPhone.Text = string.Empty;
            txtCustAddr.Text = string.Empty;
        }

        private void ddlOld_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strOldName = ddlOld.SelectedItem.ToString();
            foreach (Customer customer in customers)
            {
                if (strOldName.Equals(customer.Cust_name))
                {
                    txtCustNo.Text = customer.Cust_no.ToString();
                    txtCustName.Text = customer.Cust_name;
                    txtCustPhone.Text = customer.Cust_phone;
                    txtCustAddr.Text = customer.Cust_addr;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ddlOld.SelectedItem != null)
            {

                if (txtCustName.Text.Trim().Length < 1)
                {
                    MessageBox.Show(Messages.customer_add_noname);
                    txtCustName.Focus();
                    return;
                }

                Common.lockButton(sender);

                Customer customer = new Customer();
                customer.Cust_no = int.Parse(txtCustNo.Text);
                customer.Cust_name = txtCustName.Text.Trim();
                customer.Cust_phone = txtCustPhone.Text.Trim();
                customer.Cust_addr = txtCustAddr.Text.Trim();

                string result = customerMgr.updateCustomer(customer);
                if (result.Equals(Messages.customer_update_success))
                {
                    MessageBox.Show(Messages.customer_update_success);
                    this.Close();
                }
                else MessageBox.Show(result);

            }
            else
            {
               MessageBox.Show("Please choose old name!");
            }

            Common.unlockButton(sender);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (ddlOld.SelectedItem != null)
            //{
            //    Customer customer = new Customer();
            //    customer.Cust_no = int.Parse(txtCustNo.Text);
            //    customer.Cust_name = txtCustName.Text;
            //    customer.Cust_phone = txtCustPhone.Text;
            //    customer.Cust_addr = txtCustAddr.Text;
            //    int i = customerMgr.deleteCustomer(customer);

            //    if (i == 1)
            //    {
            //        MessageBox.Show("Delete Successful!");
            //        reload();
            //    }
            //    else MessageBox.Show("Fail!");
            //}
            //else
            //{
            //    MessageBox.Show("Please choose old name!");
            //}

            Common.lockButton(sender);

            if (ddlOld.SelectedItem != null)
            {
                    string result = customerProvider.deleteCustomer(long.Parse(txtCustNo.Text));

                    if (result.Equals(Messages.customer_delete_success))
                    {
                        MessageBox.Show(result);
                        reload();
                    }
                    else MessageBox.Show(result);

            }
            else
            {
                MessageBox.Show("Please choose old name!");
            }

            Common.unlockButton(sender);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ddlOld_DropDown(object sender, EventArgs e)
        {
            //ComboBox cbo = (ComboBox)sender;
            //cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(ddlOld_PreviewKeyDown);
        }

        private void ddlOld_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //ComboBox cbo = (ComboBox)sender;
            //cbo.PreviewKeyDown -= ddlOld_PreviewKeyDown;
            //if (cbo.DroppedDown) cbo.Focus();
        }
    }
}

