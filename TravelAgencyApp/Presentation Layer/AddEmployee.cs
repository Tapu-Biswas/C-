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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private bool name(string s)
        {
            char x = s[0];
            if (!(x >= 'A' && x <= 'Z'))
                return false;
            return true;
        }

        private bool phoneNumber(string s)
        {
            int n = s.Length;

            if (n != 11) return false;

            if (s[0] != '0')
                return false;

            if (s[1] != '1') 
                return false;
            if (s[2] != '3' && s[2] != '4' && s[2] != '5' && s[2] != '6' && s[2] != '7' && s[2] != '8' && s[2] != '9') 
                return false;

            for (int i = 0; i < n; i++)
            {
                char digit = s[i];
                if (!(digit >= '0' && digit <= '9')) return false;
            }

            return true;
        }
        private bool money(string s)
        {
            char x = s[0];
            if (!(x >= '0' && x <= '9'))
                return false;
            return true;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (!name(nametextBox.Text))
            {
                MessageBox.Show("Name first letter need to be capital");
            }
            else if (addresstextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }
            else if (phoneNumbertextBox.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty");
            }
            else if (!phoneNumber(phoneNumbertextBox.Text))
            {
                MessageBox.Show("Phone Number must be 11 digit");
            }
            else if (bloodGroupcomboBox.Text == "")
            {
                MessageBox.Show("Select a proper blood group");
            }
            else if (dateOfBirthdateTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select a proper date of birth");
            }
            else if ((maleradioButton6.Checked == false) && (femaleradioButton5.Checked == false))
            {
                MessageBox.Show("Select a gender");
            }
            else if (designationcomboBox.Text == "")
            {
                MessageBox.Show("Select a proper designation");
            }
            else if (salarytextBox.Text == "")
            {
                MessageBox.Show("Salary cannot be empty");
            }
            else if (!money(salarytextBox.Text))
            {
                MessageBox.Show("Salary need to be in digit");
            }
            else if (hireDatedateTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select a proper hiredate");
            }
            else
                {
                    Employee employee = new Employee();
                    employee.EmployeeName = nametextBox.Text;
                    employee.EmployeeUsername = userNametextBox.Text;
                    employee.EmployeeEmail = emailtextBox.Text;
                    employee.EmployeePassword = passwordtextBox.Text;
                    employee.EmployeeAddress = addresstextBox.Text;
                    employee.EmployeePhoneNumber = phoneNumbertextBox.Text;
                    employee.EmployeeBloodGroup = bloodGroupcomboBox.Text;
                    employee.EmployeeDateofBirth = dateOfBirthdateTimePicker.Text;
                    if (maleradioButton6.Checked)
                    {
                        employee.EmployeeGender = "Male";
                    }
                    else
                    {
                        employee.EmployeeGender = "Female";
                    }
                    employee.EmployeeDesignation = designationcomboBox.Text;
                    employee.EmployeeSalary = salarytextBox.Text;
                    employee.EmployeeHireDate = hireDatedateTimePicker.Text;              

                    EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                    if (employeeDataAccess.AddEmployee(employee))
                    {
                        MessageBox.Show("Employee Added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error in Adding");
                    }
                }
            }
        }
    }
