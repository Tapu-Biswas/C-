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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backempbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            UpdateCustomerList();
        }

        void UpdateCustomerList()
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeedataGridView.DataSource = employeeDataAccess.GetAllEmployees();
        }

        private void searchempbutton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeedataGridView.DataSource = employeeDataAccess.GetEmployeeDetailsById(Convert.ToInt32(searchemptextBox.Text));
        }

        private void deleteempbutton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            if (employeeDataAccess.DeleteEmployee(Convert.ToInt32(deleteemptextBox.Text)))
            {
                MessageBox.Show("Employee deleted");
                UpdateCustomerList();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
        }

        private void Updateempbutton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            if (employeeDataAccess.UpdateEmployee(Convert.ToInt32(idtextBox.Text), nametextBox.Text, userNametextBox.Text, emailtextBox.Text, passwordtextBox.Text, addresstextBox.Text, phoneNumbertextBox.Text, bloodGroupcomboBox.Text, dateOfBirthdateTimePicker.Text, gendertextBox.Text, designationcomboBox.Text, salarytextBox.Text, hiredatedateTimePicker.Text))
            {
                MessageBox.Show("Employee updated");
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
