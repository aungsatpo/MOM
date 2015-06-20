using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;

namespace MOM
{
    public class LOAN_provider
    {
        private MOMDataSet loan;
        private MOMDataSetTableAdapters.LOANTableAdapter loanAdapter;

        public LOAN_provider()
        {
            loan = new MOMDataSet();
            loanAdapter = new MOMDataSetTableAdapters.LOANTableAdapter();
        }

        public MOMDataSet.LOANDataTable getAllLoan()
        {
            return loanAdapter.getAllLoans();
            //string commandText = "SELECT * FROM LOAN WHERE ACT_IND = 'Y'";
            //CommandType commandType = CommandType.Text;
            //SqlCeParameter[] param = null;
            //SQLHelper.FillDataSet(loan, loan.LOAN.TableName, commandText, commandType, param);           
            //return loan;
        }

        public string addLoan(MOMDataSet.LOANRow row)
        {
            try
            {
                if (loanAdapter.Insert(row.ITEM_NAME, row.LOAN_AMOUNT, row.LOAN_RATE, row.START_DATE, row.CUST_NO, row.REMARKS, row.ACT_IND, row.CREATE_DT, row.UPDATE_DT) == 1) return Messages.loan_add_success;
                else return Messages.loan_add_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }

            
            //string commandText = "INSERT INTO LOAN (ITEM_NAME, ITEM_WORTH, LOAN_AMOUNT, LOAN_RATE, START_DATE, REMARKS, CUST_NO, ACT_IND, CREATE_DT, UPDATE_DT) " +
            //    "VALUES (@ITEM_NAME, @ITEM_WORTH, @LOAN_AMOUNT, @LOAN_RATE, @START_DATE, @REMARKS, @CUST_NO, @ACT_IND, @CREATE_DT, @UPDATE_DT)";
            //CommandType commandType = CommandType.Text;

            //SqlCeParameter[] param = new SqlCeParameter[] { new SqlCeParameter("@ITEM_NAME", row.ITEM_NAME),
            //                                            new SqlCeParameter("@ITEM_WORTH", row.ITEM_WORTH), 
            //                                            new SqlCeParameter("@LOAN_AMOUNT", row.LOAN_AMOUNT),
            //                                            new SqlCeParameter("@LOAN_RATE", row.LOAN_RATE), 
            //                                            new SqlCeParameter("@START_DATE", row.START_DATE),
            //                                            new SqlCeParameter("@REMARKS", row.REMARKS),
            //                                            new SqlCeParameter("@CUST_NO", row.CUST_NO), 
            //                                            new SqlCeParameter("@ACT_IND", row.ACT_IND),
            //                                            new SqlCeParameter("@CREATE_DT", row.CREATE_DT), 
            //                                            new SqlCeParameter("@UPDATE_DT", row.UPDATE_DT)};
            //return SQLHelper.ExecuteNonQuery(commandText, commandType, param);
        }

        public MOMDataSet.LOANRow getLoanByLoanNo(long p1)
        {
            return loanAdapter.getLoanByLOAN_NO(p1)[0];
        }

        public string collectLoan(long loan_no, string itemName, DateTime endDate, decimal totalInterest)
        {
            try
            {
                MOMDataSet.LOANRow row = loanAdapter.getLoanByLOAN_NO(loan_no)[0];
                row.ITEM_NAME = itemName;
                row.END_DATE = endDate;
                row.INTEREST = totalInterest;
                if (loanAdapter.Update(row) == 1) return Messages.loan_collect_success;
                else return Messages.loan_collect_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }

        }

        public string partialCollectLoan(long loan_no, string itemName, decimal loanAmount, DateTime endDate, decimal totalInterest)
        {
            try
            {
                MOMDataSet.LOANRow row = loanAdapter.getLoanByLOAN_NO(loan_no)[0];
                row.ITEM_NAME = itemName;
                row.LOAN_AMOUNT = loanAmount;
                row.END_DATE = endDate;
                row.INTEREST = totalInterest;
                if (loanAdapter.Update(row) == 1) return Messages.loan_partial_collect_success;
                else return Messages.loan_partial_collect_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }
        }

        public string partialAddLoan(MOMDataSet.LOANRow oldRow, decimal loanAmount)
        {
            try
            {
                MOMDataSet.LOANDataTable dataTable = new MOMDataSet.LOANDataTable();
                MOMDataSet.LOANRow row = dataTable.NewLOANRow();

                row.ITEM_NAME = oldRow.ITEM_NAME;
                row.LOAN_AMOUNT = loanAmount;
                row.LOAN_RATE = oldRow.LOAN_RATE;
                row.START_DATE = oldRow.START_DATE;
                row.REMARKS = oldRow.REMARKS;
                row.CUST_NO = oldRow.CUST_NO;
                row.ACT_IND = "Y";
                row.CREATE_DT = DateTime.Now;
                row.UPDATE_DT = DateTime.Now;

                return addLoan(row);       
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }

        }

        public string uncollectLoan(long loan_no)
        {
            try
            {
                MOMDataSet.LOANRow row = loanAdapter.getLoanByLOAN_NO(loan_no)[0];
                row.ACT_IND = "N";
                if (loanAdapter.Update(row) == 1) return Messages.loan_uncollect_success;
                else return Messages.loan_uncollect_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }

        }

        public string deleteLoan(long loan_no)
        {
            try
            {
                if (loanAdapter.Delete(loan_no) == 1) return Messages.loan_delete_success;
                else return Messages.loan_delete_fail;
            }

            catch (SqlCeException ex)
            {
                return ex.Message;
            }

        }

        public long getLastLoanNo()
        {
            return (long) loanAdapter.getLastLoanNo();
        }

    }

}