using System;
using System.Collections.Generic;
using System.Text;

namespace MOM
{
    public class Customer
    {
        private long cust_no;

        public long Cust_no
        {
            get { return cust_no; }
            set { cust_no = value; }
        }
        private string cust_name;

        public string Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        private string cust_phone;

        public string Cust_phone
        {
            get { return cust_phone; }
            set { cust_phone = value; }
        }
        private string cust_addr;

        public string Cust_addr
        {
            get { return cust_addr; }
            set { cust_addr = value; }
        }

        private string act_ind;

        public string Act_ind
        {
            get { return act_ind; }
            set { act_ind = value; }
        }
    }
}
