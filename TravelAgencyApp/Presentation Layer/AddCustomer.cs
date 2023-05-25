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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private bool userName(string s)
        {
            for(int i=0;i<s.Length;i++)
            {
                char x = s[i];
                if (!(x >= 'a' && x <= 'z') && !(x >= '0' && x <= '9'))
                    return false;
            }
            return true;
        }

        private bool name(string s)
        {
            char x = s[0];
            if (!(x >= 'A' && x <= 'Z'))
                return false;
            return true;
        }

        private bool email(string s)
        {
            int n = s.Length;
            // @gmail.com , @yahoo.com
            if (n< 10)
                return false;

            if (s.Substring(n - 10) == "@gmail.com" || s.Substring(n - 10) == "@yahoo.com")
                return true;
            else
                return false;
        }

        private bool password(string s)
        {
            int n = s.Length;
            if (n >= 8) 
                return true;
            else 
                return false;
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
            else if (userNametextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (!userName(userNametextBox.Text))
            {
                MessageBox.Show("Username need to in small letter");
            }
            else if (emailtextBox.Text == "" || !email(emailtextBox.Text))
            {
                MessageBox.Show("Email invalid");
            }
            else if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (!password(passwordtextBox.Text))
            {
                MessageBox.Show("Password must be atleast 8 digit");
            }
            else if (dateOfBirthdateTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select a proper date of birth");
            }
            else if ((maleradioButton6.Checked == false) && (femaleradioButton5.Checked == false))
            {
                MessageBox.Show("Select a gender");
            }
                else
                {
                    Customer customer = new Customer();
                    customer.CustomerName = nametextBox.Text;
                    customer.CustomerUsername = userNametextBox.Text;
                    customer.CustomerEmail = emailtextBox.Text;
                    customer.CustomerPassword = passwordtextBox.Text;
                    customer.CustomerDateofBirth = dateOfBirthdateTimePicker.Text;
                    if (maleradioButton6.Checked)
                    {
                        customer.CustomerGender = "Male";
                    }
                    else
                    {
                        customer.CustomerGender = "Female";
                    }


                    CustomerDataAccess customerDataAccess = new CustomerDataAccess();
                    if (customerDataAccess.AddCustomer(customer))
                    {
                        MessageBox.Show("Customer Added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error in Adding Customer");
                    }
                }
            }
        }
    }

