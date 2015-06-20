using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;



namespace MOM
{
    public class Customer_Manager
    {
        private CUSTOMER_provider customerProvider;

        public Customer_Manager()
        {
            customerProvider = new CUSTOMER_provider();
        }

        public List<Customer> getAllCustomer()
        {
            customerProvider = new CUSTOMER_provider();
            MOMDataSet.CUSTOMERDataTable dsCustomer = customerProvider.getAllCustomer();
            if (dsCustomer != null)
            {
                List<Customer> customers = new List<Customer>();
                foreach (MOMDataSet.CUSTOMERRow row in dsCustomer.Rows)
                {
                    Customer customer = new Customer();
                    customer.Cust_no = row.CUST_NO;
                    customer.Cust_name = row.CUST_NAME;
                    customer.Cust_phone = row.CUST_PHONE;
                    customer.Cust_addr = row.CUST_ADDR;
                    customers.Add(customer);
                }
                return customers;
            }
            return null;
        }

        public string addCustomer(Customer customer)
        {
            MOMDataSet.CUSTOMERDataTable dataTable = new MOMDataSet.CUSTOMERDataTable();
            MOMDataSet.CUSTOMERRow row = dataTable.NewCUSTOMERRow();

            row.CUST_NO = 0;
            row.CUST_NAME = customer.Cust_name;
            row.CUST_PHONE = customer.Cust_phone;
            row.CUST_ADDR = customer.Cust_addr;
            return customerProvider.addCustomer(row);
        }

        public string updateCustomer(Customer customer)
        {
            MOMDataSet.CUSTOMERDataTable dataTable = new MOMDataSet.CUSTOMERDataTable();
            MOMDataSet.CUSTOMERRow row = dataTable.NewCUSTOMERRow();

            row.CUST_NO = customer.Cust_no;
            row.CUST_NAME = customer.Cust_name;
            row.CUST_PHONE = customer.Cust_phone;
            row.CUST_ADDR = customer.Cust_addr;
            return customerProvider.updateCustomer(row);
        }


    }
}
