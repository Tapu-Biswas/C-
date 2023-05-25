using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Data_Access_Layer;

namespace TravelAgencyApp.Presentation_Layer
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backcusbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            UpdateCustomerList();
        }

        void UpdateCustomerList()
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerdataGridView.DataSource = customerDataAccess.GetAllCustomers();
        }

        private void deletecusbutton_Click(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            if (customerDataAccess.DeleteCustomer(Convert.ToInt32(deletecustextBox.Text)))
            {
                MessageBox.Show("Customer deleted");
                UpdateCustomerList();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
        }

        private void searchcusbutton_Click(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerdataGridView.DataSource = customerDataAccess.GetCustomerDetailsById(Convert.ToInt32(searchcustextBox.Text));
        }

        private void Updatecusbutton_Click(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            if (customerDataAccess.UpdateCustomer(Convert.ToInt32(custIDtextBox.Text),upcusnametextBox.Text,upcususerNametextBox.Text, upcusemailtextBox.Text, upcuspasswordtextBox.Text, upcusdateOfBirthdateTimePicker.Text, gendertextBox.Text))
            {
                MessageBox.Show("Customer updated");
                UpdateCustomerList();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            UpdateCustomerList();
        }
    }
}
