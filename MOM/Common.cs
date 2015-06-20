using System;   
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace MOM
{
    public class Common 
    {
        public static decimal calculateInterest(DateTime startDate, DateTime endDate, decimal loanAmount, double rate)
        {
            
            decimal dRate = (decimal)rate;
            decimal days = (decimal)getTotalDays(startDate, endDate);
            return ((loanAmount * (dRate * 0.01M)) / 30) * days;
        }

        public static double getTotalDays(DateTime startDate, DateTime endDate)
        {
            startDate = DateTime.Parse(startDate.ToShortDateString());
            endDate = DateTime.Parse(endDate.ToShortDateString());
            return endDate.Subtract(startDate).TotalDays;
        }

        public static void lockButton(object sender)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Enabled = false;
        }

        public static void unlockButton(object sender)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Enabled = true;
        }
    }
}
