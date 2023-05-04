using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CG.Banking.BL
{
    public class Customer : Person
    {
        // Fields

        
        // Properties
        public int ID { get; set; }

        public Deposit? LastDeposit
        {
            get
            {
                if (DepositList.Count > 0) { 
                    return DepositList.OrderByDescending(d => d.Date).FirstOrDefault(); 
                }
                else { return null; }
            }
        }

        public Withdrawal? Lastwithdrawal
        {
            get
            {
                if (WithdrawalList.Count > 0)
                {
                    return WithdrawalList.OrderByDescending(d => d.Date).FirstOrDefault();
                }
                else { return null; }
            }
        }

        public List<Deposit> DepositList { get; set; } = new List<Deposit>();

        public List<Withdrawal>  WithdrawalList { get; set; } = new List<Withdrawal>();


        // --- Constructors --- 
        public Customer() { } // Default

        public Customer(int id, string firstanme, string lastname, string ssn, DateTime dob)
        {
            // New Customer Constructor
            ID = id;
            FirstName = firstanme;
            LastName = lastname;
            SSN = ssn;
            DOB = dob;
        }
            // SQL Constructor
        public Customer(DataRow customerRow)
        {
            ID = Convert.ToInt32(customerRow["CustomerID"]);
            SSN = Convert.ToString(customerRow["SSN"])!;
            FirstName = Convert.ToString(customerRow["FirstName"])!;
            LastName = Convert.ToString(customerRow["LastName"])!;
            DOB = Convert.ToDateTime(customerRow["DOB"])!;
        }

        // --- Methods --- 

        public int CompareTo(Customer? other)
        {
            if (LastName.CompareTo(other!.LastName) == 0)
            {
                return FirstName.CompareTo(other!.FirstName);
            }

            return LastName.CompareTo(other!.LastName);
        }

        // --- SQL Methods

        public void LoadDepositListFromDB()
        {
            DepositList.Clear();

            string sql = "SELECT * FROM transactions WHERE OwnerId = @ID and amount > 0";
            DataTable table = DataAccess.SelectFromDB(sql, GetParameters());

            foreach (DataRow row in table.Rows)
            {
                DepositList.Add(new Deposit(row));
            }
        }

        public void LoadWithdrawalListFromDB()
        {
            WithdrawalList.Clear();

            string sql = "SELECT * FROM transactions WHERE OwnerId = @ID and amount < 0";
            DataTable table = DataAccess.SelectFromDB(sql, GetParameters());

            foreach (DataRow row in table.Rows)
            {
                WithdrawalList.Add(new Withdrawal(row));
            }
        }

        public void InsertIntoDB()
        {
            string sql = "INSERT INTO customers(CustomerID, SSN, FirstName, LastName, DOB) "
                + "VALUES(@ID, @SSN, @FirstName, @LastName, @DOB); SELECT SCOPE_IDENTITY()";

            ID = DataAccess.ExecuteSql(sql, GetParameters());
        }

        public void UpdateDB()
        {
            string sql = "UPDATE customers SET SSN = @SSN, FirstName = @FirstName, LastName = @LastName, "
                + "DOB = @DOB WHERE CustomerID = @ID";

            DataAccess.ExecuteSql(sql, GetParameters());
        }

        public void DeleteFromDB()
        {
            string sql = "DELETE FROM customers WHERE CustomerID = @ID";

            DataAccess.ExecuteSql(sql, GetParameters());
        }



        // Basic 
        private List<SqlParameter> GetParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", ID));
            parameters.Add(new SqlParameter("@SSN", SSN));
            parameters.Add(new SqlParameter("@FirstName", FirstName));
            parameters.Add(new SqlParameter("@LastName", LastName));
            parameters.Add(new SqlParameter("@DOB", DOB));
            return parameters;
        }

    }
}
