using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormListBoxExample
{
    public partial class ListBoxExample : Form
    {
        private List<Customer> _customers;

        public ListBoxExample()
        {
            InitializeComponent();
            SetupCustomers();
            SetupListBox();
        }

        private void SetupCustomers()
        {
            _customers = new List<Customer>
            {
                new Customer(1, "RandomCustomer1"),
                new Customer(2, "RandomCustomer2"),
                new Customer(3, "RandomCustomer3"),
                new Customer(4, "RandomCustomer4")
            };
        }

        private void SetupListBox()
        {
            listBox.DataSource = _customers;
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
        }

        private void displayCustomerDataButton_Click(object sender, System.EventArgs e)
        {
            if (listBox.SelectedItem is Customer selectedCustomer)
            {
                MessageBox.Show($@"The selected customer is {selectedCustomer.Name} with id {selectedCustomer.Id}");
            }
        }
    }
}
