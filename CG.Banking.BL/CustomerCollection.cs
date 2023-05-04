using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Banking.BL
{
    public delegate void OnCustomerAdded(); // Delegate

    public class CustomerCollection : List<Customer> // list of customers
    {
        // Fields
        public OnCustomerAdded? OnAdd { get; set; }

        // --- Constructor ---
        public CustomerCollection()
        {
            DataAccess.XMLFilePath = "customers.xml";
            DataAccess.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        // Methods

        public void Populate()
        {
            Customer customer;

            customer = new Customer(1, "John", "Doe", "123-45-6789", new DateTime(1990, 1, 1));
            Add(customer);
            // Deposits
            customer.DepositList.Add(new Deposit(1, 400.00, new DateTime(2023, 4, 16)));
            customer.DepositList.Add(new Deposit(2, 500.00, new DateTime(2023, 4, 15)));
            customer.DepositList.Add(new Deposit(3, 600.00, new DateTime(2023, 4, 14)));
            // Withdrawals
            customer.WithdrawalList.Add(new Withdrawal(1, 100.00, new DateTime(2023, 4, 16)));
            customer.WithdrawalList.Add(new Withdrawal(2, 200.00, new DateTime(2023, 4, 15)));
            customer.WithdrawalList.Add(new Withdrawal(3, 300.00, new DateTime(2023, 4, 14)));
            

            customer = new Customer(2, "Jane", "Smith", "987-65-4321", new DateTime(1995, 2, 2));
            Add(customer);
            // Deposits
            customer.DepositList.Add(new Deposit(1, 100.00, new DateTime(2023, 4, 16)));
            customer.DepositList.Add(new Deposit(2, 200.00, new DateTime(2023, 4, 15)));
            customer.DepositList.Add(new Deposit(3, 300.00, new DateTime(2023, 4, 14)));
            // Withdrawals
            customer.WithdrawalList.Add(new Withdrawal(1, 100.00, new DateTime(2023, 4, 16)));
            customer.WithdrawalList.Add(new Withdrawal(2, 200.00, new DateTime(2023, 4, 15)));
            customer.WithdrawalList.Add(new Withdrawal(3, 300.00, new DateTime(2023, 4, 14)));


            customer = new Customer(3, "Mark", "Johnson", "456-78-9123", new DateTime(1985, 3, 3));
            Add(customer);
            // Deposits
            customer.DepositList.Add(new Deposit(1, 900.00, new DateTime(2023, 4, 16)));
            customer.DepositList.Add(new Deposit(2, 600.00, new DateTime(2023, 4, 15)));
            customer.DepositList.Add(new Deposit(3, 337.00, new DateTime(2023, 4, 14)));
            // Withdrawals
            customer.WithdrawalList.Add(new Withdrawal(1, 54.81, new DateTime(2023, 4, 16)));
            customer.WithdrawalList.Add(new Withdrawal(2, 200.00, new DateTime(2023, 4, 15)));
            customer.WithdrawalList.Add(new Withdrawal(3, 300.00, new DateTime(2023, 4, 14)));
        }

        public void SaveToXml()
        {
            DataAccess.SaveXml(typeof(CustomerCollection), this);
        }


        public new void Add(Customer customer)
        {
            base.Add(customer);
            OnAdd?.Invoke();
        }

        public void LoadFromDB()
        {
            string sql = "SELECT * FROM customers";
            DataTable table = DataAccess.SelectFromDB(sql);
            foreach (DataRow row in table.Rows)
            {
                Add(new Customer(row));
            }
        }

    }
}
