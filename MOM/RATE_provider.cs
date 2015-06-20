using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;

namespace MOM
{
    public class RATE_provider
    {
        private MOMDataSet rate;
        private MOMDataSetTableAdapters.RATETableAdapter rateAdapter;

        public RATE_provider()
        {
            rate = new MOMDataSet();
            rateAdapter = new MOMDataSetTableAdapters.RATETableAdapter();
        }



        public int addRate(MOMDataSet.RATERow row)
        {
            return rateAdapter.Insert((double)row.RATE_RATE, row.RATE_DATE, row.REMARKS, row.CREATE_DT, row.UPDATE_DT);
            //string commandText = "INSERT INTO RATE (RATE_RATE, RATE_DATE, REMARKS, CREATE_DT, UPDATE_DT) " +
            //    "VALUES (@RATE_RATE, @RATE_DATE, @REMARKS, @CREATE_DT, @UPDATE_DT)";
            //CommandType commandType = CommandType.Text;

            //SqlCeParameter[] param = new SqlCeParameter[] { new SqlCeParameter("@RATE_RATE", row.RATE_RATE),
            //                                            new SqlCeParameter("@RATE_DATE", row.RATE_DATE), 
            //                                            new SqlCeParameter("@REMARKS", row.REMARKS),
            //                                            new SqlCeParameter("@CREATE_DT", row.CREATE_DT), 
            //                                            new SqlCeParameter("@UPDATE_DT", row.UPDATE_DT)};
            //return SQLHelper.ExecuteNonQuery(commandText, commandType, param);
        }

        public decimal getCurrentRate()
        {
            try
            {
                return (decimal)rateAdapter.getCurrentRate();
            }
            catch (Exception)
            {
                return 0.0M;
            }
            
        }

    }

}