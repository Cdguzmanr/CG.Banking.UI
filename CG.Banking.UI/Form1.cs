using CG.Banking.BL;
using System.ComponentModel;
using System.Xml.Linq;

namespace CG.Banking.UI
{
    public partial class Form1 : Form
    {
        // Fields
        public CustomerCollection customers = new CustomerCollection();


        public Form1()
        {
            InitializeComponent();

            /* ------ XML LOAD CUSTOMERS --------
            // Loads customers from storage -> XML 
            Type type = typeof(CustomerCollection);
            try
            {
                CustomerCollection? temp = DataAccess.LoadXml(type) as CustomerCollection;
                customers = (temp != null) ? temp : new CustomerCollection();
            }
            catch
            {
                customers = new CustomerCollection();
            }
            */

            customers.OnAdd += RebindCustomers;

            customers.LoadFromDB();


            /*
            if (customers.Count > 0)
            {
                customers.Sort();
                RebindCustomers();
            }
            */


        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                lblTextID.Text = selectedCustomer.ID.ToString();
                txtFName.Text = selectedCustomer.FirstName;
                txtLName.Text = selectedCustomer.LastName;
                txtSSN.Text = selectedCustomer.SSN;
                txtBDate.Text = selectedCustomer.DOB.ToString("d");
                lblTextAge.Text = selectedCustomer.Age.ToString();

                selectedCustomer.LoadDepositListFromDB();
                selectedCustomer.LoadWithdrawalListFromDB();


                // Display the Deposits and Withdrawals from the selected customer
                RebindFinancials(selectedCustomer.DepositList, selectedCustomer.WithdrawalList);
            }
        }

        private void RebindFinancials(List<Deposit> deposits, List<Withdrawal> withdrawals)
        {

            dgvDeposits.DataSource = deposits;
            dgvDeposits.Columns["Amount"].DefaultCellStyle.Format = "c"; // formating for currency
                

            dgvWithdrawals.DataSource = withdrawals;
            dgvWithdrawals.Columns["Amount"].DefaultCellStyle.Format = "c"; // formating for currency


        }

        private void dgv_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgvSender = (DataGridView)sender;

            if (dgvSender.Rows.Count == 0)
            {
                using (Graphics g = e.Graphics)
                {
                    g.FillRectangle(Brushes.DarkGray, new Rectangle(new Point(), new Size(dgvSender.Width, dgvSender.Height)));
                    g.DrawString("No data to display", new Font("Arial", 12), Brushes.White, new PointF(3, 3));
                }
            }
        }

        private void RebindCustomers()
        {
            //customers.Sort(SortCustomers);

            // anonymous function
            //customers.Sort(delegate (Customer c1, Customer c2)
            //{
            //    return c1.CompareTo(c2);
            //});

            // same thing using a lambda expression
            //customers.Sort((c1, c2) => c1.CompareTo(c2));

            lstCustomers.DataSource = null; // unbind
            lstCustomers.DataSource = customers; // re-bind
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Autoincrement the ID     // I love these ternary operators haha
            lblTextID.Text = (customers.Count > 0 ? (customers.OrderByDescending(u => u.ID).FirstOrDefault()!.ID + 1) : 0).ToString();


            txtFName.Text = "";
            txtLName.Text = "";
            txtSSN.Text = "";
            txtBDate.Text = "";
            lblTextAge.Text = "";

            lstCustomers.ClearSelected();
            dgvDeposits.DataSource = null;
            dgvWithdrawals.DataSource = null;
            txtFName.Focus();
        }


        /*
        public int CompareTo(Customer? other)
        {
            if (LastName.CompareTo(other!.LastName) == 0)
            {
                return FirstName.CompareTo(other!.FirstName);
            }

            return LastName.CompareTo(other!.LastName);
        }
        */


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Input validations
            if (txtFName.Text.Length <= 0) { MessageBox.Show("Please type a valid First Name"); return; }
            else if (txtLName.Text.Length <= 0) { MessageBox.Show("Please type a valid Last Name"); return; }
            else if (txtSSN.Text.Length <= 0) { MessageBox.Show("Please type a valid SSN"); return; }
            else if (txtBDate.Text.Length <= 0) { MessageBox.Show("Please type a valid Date"); return; }

            try
            {
                // This could probably be simplified but meh

                Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
                if (selectedCustomer != null) // Update Customer
                {
                    selectedCustomer.ID = int.Parse(lblTextID.Text);
                    selectedCustomer.FirstName = txtFName.Text;
                    selectedCustomer.LastName = txtLName.Text;
                    selectedCustomer.SSN = txtSSN.Text;
                    selectedCustomer.DOB = DateTime.Parse(txtBDate.Text);
                    selectedCustomer.UpdateDB();
                }
                else
                {
                    Customer customer = new(); // Create new customer
                    customer.ID = int.Parse(lblTextID.Text);
                    customer.FirstName = txtFName.Text;
                    customer.LastName = txtLName.Text;
                    customer.SSN = txtSSN.Text;
                    customer.DOB = DateTime.Parse(txtBDate.Text);
                    
                    MessageBox.Show("Customer added");


                    // Save
                    customers.Add(customer);
                    customer.InsertIntoDB();
                }

                RebindCustomers();

            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return;
            }
            catch (Exception exc)
            {
                // if (string.IsNullOrEmptyText)) MessageBox.Show("please enter a customer name");
                MessageBox.Show("Something REALLY went wrong!!!");
                return;
            }
            txtFName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to permanetely delete this customer?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return; // Cancel action

            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                customers.Remove(selectedCustomer);
                selectedCustomer.DeleteFromDB();
                RebindCustomers();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Create customers from XML
                Type type = typeof(CustomerCollection);
                CustomerCollection? temp = DataAccess.LoadXml(type) as CustomerCollection;
                customers = (temp != null) ? temp : new CustomerCollection();

                // Display message
                MessageBox.Show("Document loaded successfully");

                // Load customers on list
                RebindCustomers();
            }
            catch
            {
                MessageBox.Show("No XML document load");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customers.SaveToXml();
                MessageBox.Show("Customers saved on XML");
                RebindCustomers();
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        // I could create a flag to follow the changes and save only on unsaved changes 
        // but meh
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save your changes to this file?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                customers.SaveToXml();
                MessageBox.Show("Customers saved on XML");
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}