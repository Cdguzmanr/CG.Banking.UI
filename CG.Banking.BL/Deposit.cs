using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CG.Banking.BL
{
    public class Deposit
    {
        // Fields

        // Properties
        public int DepositID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }


        // --- Constructors --- 
        public Deposit() { }

        public Deposit(int depositID, double amount, DateTime date)
        {
            DepositID = depositID;
            Amount = amount;
            Date = date;
        }

        // SQL Constructor
        public Deposit(DataRow depositRow)
        {
            DepositID = Convert.ToInt32(depositRow["TransactionID"]);
            Amount = Convert.ToDouble(depositRow["Amount"])!;
            Date = Convert.ToDateTime(depositRow["TransactionDate"])!;
        }


        // Methods


    }
}

/*
a.	ID (int)
b.	Amount (double)
c.	Date (DateTime)
*/