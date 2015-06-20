using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;



namespace MOM
{
    public class Rate_Manager
    {
        private RATE_provider rateProvider;

        public Rate_Manager()
        {
            rateProvider = new RATE_provider();
        }

        //public List<Rate> getCurrentRate()
        //{
        //    rateProvider = new RATE_provider();
        //    MOMDataSet dsRate = rateProvider.getCurrentRate();
        //    if (dsRate != null)
        //    {
        //        List<Rate> rates = new List<Rate>();
        //        foreach (MOMDataSet.RATERow row in dsRate.RATE.Rows)
        //        {
        //            Rate rate = new Rate();
        //            rate.Rate_rate = row.RATE_RATE;
        //            rate.Rate_date = row.RATE_DATE;
        //            rate.Remarks = row.REMARKS;
        //            rate.Create_dt = row.CREATE_DT;
        //            rate.Update_dt = row.UPDATE_DT;
        //            rates.Add(rate);
        //        }
        //        return rates;
        //    }
        //    return null;
        //}

        public int addRate(Rate rate)
        {
            MOMDataSet.RATEDataTable dataTable = new MOMDataSet.RATEDataTable();
            MOMDataSet.RATERow row = dataTable.NewRATERow();

            //row.RATE_RATE = 0;
            row.RATE_RATE = rate.Rate_rate;
            row.RATE_DATE = rate.Rate_date;
            row.REMARKS = rate.Remarks;
            row.CREATE_DT = rate.Create_dt;
            row.UPDATE_DT = rate.Update_dt;
            return rateProvider.addRate(row);
        }

    }
}
