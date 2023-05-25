using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyApp.Presentation_Layer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutpictureBox_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void empdatabasebutton_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Show();
            this.Hide();
        }

        private void empAddbutton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Hide();
        }

        private void cusdatabasebutton_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
            this.Hide();
        }

        private void cusAddbutton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void bookdatabasebutton_Click(object sender, EventArgs e)
        {
            BookingManagement bookingManagement = new BookingManagement();
            bookingManagement.Show();
            this.Hide();
        }

        private void bookAddbutton_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.Show();
            this.Hide();
        }

        string userName;
        public Dashboard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (userName == "admin"){}

            else
                EmployeegroupBox.Hide();
        }
    }
}
