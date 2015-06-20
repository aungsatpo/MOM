using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;

namespace MOM
{
    public class CUSTOMER_provider
    {
        private MOMDataSet customer;
        private MOMDataSetTableAdapters.CUSTOMERTableAdapter customerAdapter;
        public CUSTOMER_provider()
        {
            customer = new MOMDataSet();
            customerAdapter = new MOMDataSetTableAdapters.CUSTOMERTableAdapter();
        }

        public MOMDataSet.CUSTOMERDataTable getAllCustomer()
        {
            return customerAdapter.getAllCustomers();
            /*
            string commandText = "SELECT * FROM CUSTOMER WHERE ACT_IND = 'Y'";
            CommandType commandType = CommandType.Text;
            SqlCeParameter[] param = null;
            SQLHelper.FillDataSet(customer, customer.CUSTOMER.TableName, commandText, commandType, param);           
            return customer;
             * */
        }

        public string addCustomer(MOMDataSet.CUSTOMERRow row)
        {
            try
            {
                if (customerAdapter.Insert(row.CUST_NAME, row.CUST_PHONE, row.CUST_ADDR, "Y") == 1) return Messages.customer_add_success;
                else return Messages.customer_add_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }
            

            /*
            string commandText = "INSERT INTO CUSTOMER (CUST_NAME, CUST_PHONE, CUST_ADDR, ACT_IND) VALUES (@CUST_NAME, @CUST_PHONE, @CUST_ADDR, 'Y')";
            CommandType commandType = CommandType.Text;
            SqlCeParameter[] param = new SqlCeParameter[] { new SqlCeParameter("@CUST_NAME", row.CUST_NAME),
                                                        new SqlCeParameter("@CUST_PHONE", row.CUST_PHONE), 
                                                        new SqlCeParameter("@CUST_ADDR", row.CUST_ADDR)};
            return SQLHelper.ExecuteNonQuery(commandText, commandType, param);*/
        }

        public string updateCustomer(MOMDataSet.CUSTOMERRow row)
        {
            try
            {
                row.ACT_IND = "Y";
                if (customerAdapter.Update(row.CUST_NAME, row.CUST_PHONE, row.CUST_ADDR, row.ACT_IND, row.CUST_NO) == 1) return Messages.customer_update_success;
                else return Messages.customer_update_fail;
            }
            catch (SqlCeException ex)
            {
                return ex.Message;
            }
            /*
            string commandText = "UPDATE CUSTOMER SET CUST_NAME = @CUST_NAME, CUST_PHONE = @CUST_PHONE, CUST_ADDR = @CUST_ADDR WHERE CUST_NO = @CUST_NO";
            CommandType commandType = CommandType.Text;
            Console.WriteLine(row.CUST_NO);
            Console.WriteLine(row.CUST_NAME);
            Console.WriteLine(row.CUST_PHONE);
            Console.WriteLine(row.CUST_ADDR);
            SqlCeParameter[] param = new SqlCeParameter[] { 
                                                        new SqlCeParameter("@CUST_NO", row.CUST_NO), 
                                                        new SqlCeParameter("@CUST_NAME", row.CUST_NAME),
                                                        new SqlCeParameter("@CUST_PHONE", row.CUST_PHONE), 
                                                        new SqlCeParameter("@CUST_ADDR", row.CUST_ADDR)};
            return SQLHelper.ExecuteNonQuery(commandText, commandType, param);
             * */
        }

        public string deleteCustomer(long p1)
        {
            try
            {
                if (customerAdapter.Delete(p1) == 1) return Messages.customer_delete_success;
                else return Messages.customer_delete_fail;
            }
            
            catch (SqlCeException ex)
            {
                return ex.Message;
            }
            
        }

        public String getCustomerName(long p1)
        {
            return customerAdapter.getCustomerByCUST_NO(p1)[0].CUST_NAME;
        }
    }

}