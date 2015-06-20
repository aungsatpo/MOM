using System;
using System.Collections.Generic;
using System.Text;

namespace MOM
{
    public class Messages
    {
        public static string customer_add_noname = "Customer Name must be entered!";
        public static string customer_add_success = "Customer Added";
        public static string customer_add_fail = "Fail!";

        public static string customer_update_success = "Customer Updated";
        public static string customer_update_fail = "Fail!";

        public static string customer_delete_success = "Delete Successful";
        public static string customer_delete_fail = "Delete Fail!";
        public static string customer_delete_fail_constraint = "This customer cannot be deleted as there is a loan for this customer.";

        public static string loan_add_success = "Loan Successful! Loan Number is ";
        public static string loan_add_fail = "Loan fail!!!";

        public static string loan_collect_success = "Collection Succeed";
        public static string loan_collect_fail = "Collection fail!!!";

        public static string loan_partial_collect_invalid_amount = "Loan Amount entered is invalid. It must be the same or less than original amount.";
        public static string loan_partial_collect_success = "Partial Collection Succeed for Loan Number ";
        public static string loan_partial_collect_fail = "Partial Collection Failed";

        public static string loan_uncollect_success = "Uncollection Succeed";
        public static string loan_uncollect_fail = "Uncollection fail!!!";

        public static string loan_delete_success = "Loan Deleted.";
        public static string loan_delete_fail = "Delete fail!!!";
    }
}
