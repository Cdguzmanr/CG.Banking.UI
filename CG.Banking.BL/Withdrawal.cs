using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Banking.BL
{
    public class Withdrawal
    {
        // Fields


        // Properties
        public int WithdrawalID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        // --- Constructors --- 
        public Withdrawal() { }
        public Withdrawal(int withdrawalID, double amount, DateTime date)
        {
            WithdrawalID = withdrawalID;
            Amount = amount;
            Date = date;
        }

        // SQL Cosntructor
        public Withdrawal(DataRow depositRow)
        {
            WithdrawalID = Convert.ToInt32(depositRow["TransactionID"]);
            Amount = Convert.ToDouble(depositRow["Amount"])!;
            Date = Convert.ToDateTime(depositRow["TransactionDate"])!;
        }

        // Methods

    }
}
