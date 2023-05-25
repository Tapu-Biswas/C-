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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string globalUser;

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool userName(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char x = s[i];
                if (!(x >= 'a' && x <= 'z') && !(x >= '0' && x <= '9'))
                    return false;
            }
            return true;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");

            }
            else if (!userName(usernametextBox.Text))
            {
                MessageBox.Show("Username invalid");

            }
            else if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                globalUser = usernametextBox.Text;

                LoginDataAccess userDataAccess = new LoginDataAccess();
                if (userDataAccess.LoginValidation(usernametextBox.Text, passwordtextBox.Text))
                {
                    Dashboard dashboard = new Dashboard(globalUser);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}
