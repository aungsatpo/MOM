using System;
using System.Collections.Generic;
using System.Text;

namespace MOM
{
    public class Loan
    {
        private long loan_no;

        public long Loan_no
        {
            get { return loan_no; }
            set { loan_no = value; }
        }


        private string item_name;

        public string Item_name
        {
            get { return item_name; }
            set { item_name = value; }
        }

        private Decimal loan_amount;

        public Decimal Loan_amount
        {
            get { return loan_amount; }
            set { loan_amount = value; }
        }

        private double loan_rate;

        public double Loan_rate
        {
            get { return loan_rate; }
            set { loan_rate = value; }
        }


        private DateTime start_date;

        public DateTime Start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }


        private DateTime end_date;

        public DateTime End_date
        {
            get { return end_date; }
            set { end_date = value; }
        }


        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        private long cust_no;

        public long Cust_no
        {
            get { return cust_no; }
            set { cust_no = value; }
        }


        private string act_ind;

        public string Act_ind
        {
            get { return act_ind; }
            set { act_ind = value; }
        }


        private DateTime create_dt;

        public DateTime Create_dt
        {
            get { return create_dt; }
            set { create_dt = value; }
        }


        private DateTime update_dt;

        public DateTime Update_dt
        {
            get { return update_dt; }
            set { update_dt = value; }
        }




    }
}
