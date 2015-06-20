using System;
using System.Collections.Generic;
using System.Text;

namespace MOM
{
    public class Rate
    {
        private int rate_no;

        public int Rate_no
        {
            get { return rate_no; }
            set { rate_no = value; }
        }
        private decimal rate_rate;

        public decimal Rate_rate
        {
            get { return rate_rate; }
            set { rate_rate = value; }
        }
        private DateTime rate_date;

        public DateTime Rate_date
        {
            get { return rate_date; }
            set { rate_date = value; }
        }
        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
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
