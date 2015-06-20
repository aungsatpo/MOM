using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;



namespace MOM
{
    public class Loan_Manager
    {
        private LOAN_provider loanProvider;

        public Loan_Manager()
        {
            loanProvider = new LOAN_provider();
        }

        public List<Loan> getAllLoan()
        {
            MOMDataSet.LOANDataTable dsLoan = loanProvider.getAllLoan();
            if (dsLoan != null)
            {
                List<Loan> loans = new List<Loan>();
                foreach (MOMDataSet.LOANRow row in dsLoan.Rows)
                {
                    Loan loan = new Loan();
                    //loan.Cust_no = row.CUST_NO;
                    loan.Loan_no = row.LOAN_NO;
                    loan.Item_name = row.ITEM_NAME;
                    loan.Loan_amount = row.LOAN_AMOUNT;
                    loan.Loan_rate = row.LOAN_RATE;
                    loan.Start_date = row.START_DATE;
                    loan.End_date = row.END_DATE;
                    loan.Remarks = row.REMARKS;
                    loan.Cust_no = row.CUST_NO;
                    loan.Act_ind = row.ACT_IND;
                    loan.Create_dt = row.CREATE_DT;
                    loan.Update_dt = row.UPDATE_DT;

                    loans.Add(loan);
                }
                return loans;
            }
            return null;
        }

        public string addLoan(Loan loan)
        {
            MOMDataSet.LOANDataTable dataTable = new MOMDataSet.LOANDataTable();
            MOMDataSet.LOANRow row = dataTable.NewLOANRow();

            row.ITEM_NAME = loan.Item_name;
            row.LOAN_AMOUNT = loan.Loan_amount;
            row.LOAN_RATE = loan.Loan_rate;
            row.START_DATE = loan.Start_date;
            row.END_DATE = loan.End_date;
            row.REMARKS = loan.Remarks;
            row.CUST_NO = loan.Cust_no;
            row.ACT_IND = loan.Act_ind;
            row.CREATE_DT = loan.Create_dt;
            row.UPDATE_DT = loan.Update_dt;

            return loanProvider.addLoan(row);            
        }
    }
}
