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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void AddBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addbooingbackbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private bool number(string s)
        {
            char x = s[0];
            if (!(x >= '1' && x <= '9'))
                return false;
            return true;
        }

        private bool alphabet(string s)
        {
            char x = s[0];
            if (!(x >= 'A' && x <= 'Z') && !(x >= 'a' && x <= 'z'))
                return false;
            return true;
        }

        private void addbookingconfirmbutton_Click(object sender, EventArgs e)
        {
            if (customeridtextBox.Text == "")
            {
                MessageBox.Show("Customer ID cannot be empty");
            }
            else if (!number(customeridtextBox.Text))
            {
                MessageBox.Show("Customer need to be in digit");
            }
            else if (dateTimePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Select a proper date of birth");
            }
            else if (countrytextBox.Text == "")
            {
                MessageBox.Show("Country cannot be empty");
            }
            else if (!alphabet(countrytextBox.Text))
            {
                MessageBox.Show("Country name need to be in alphabet");
            }
            else if (flightcomboBox.Text == "")
            {
                MessageBox.Show("Select a proper flight");
            }
            else if (hotelcomboBox.Text == "")
            {
                MessageBox.Show("Select a proper hotel");
            }
            else if (desirableplacetextBox.Text == "")
            {
                MessageBox.Show("Desirable Place cannot be empty");
            }
            else if (!alphabet(desirableplacetextBox.Text))
            {
                MessageBox.Show("Desirable Place need to be in alphabet");
            }
            else if (tourridecomboBox.Text == "")
            {
                MessageBox.Show("Select a proper tour ride");
            }
            else if (persontextBox.Text == "")
            {
                MessageBox.Show("Person cannot be empty");
            }
            else if (!number(persontextBox.Text))
            {
                MessageBox.Show("Person need to be in digit");
            }
            else if (totalcosttextBox.Text == "")
            {
                MessageBox.Show("Total Cost cannot be empty");
            }
            else if (!number(totalcosttextBox.Text))
            {
                MessageBox.Show("Total cost need to be in digit");
            }
            else if (payoptioncomboBox.Text == "")
            {
                MessageBox.Show("Select a pay option");
            }
            else if (statuscomboBox.Text == "")
            {
                MessageBox.Show("Select a status");
            }

            else
            {
                Booking booking = new Booking();
                booking.CustomerId = Convert.ToInt32(customeridtextBox.Text);
                booking.Date = dateTimePicker.Text;
                booking.Country = countrytextBox.Text;
                booking.Flight = flightcomboBox.Text;
                booking.Hotel = hotelcomboBox.Text;
                booking.DesirablePlace = desirableplacetextBox.Text;
                booking.TourRide = tourridecomboBox.Text;
                booking.Person = persontextBox.Text;
                booking.TotalCost = totalcosttextBox.Text;
                booking.PayOption = payoptioncomboBox.Text;
                booking.Status = statuscomboBox.Text;

                BookingDataAccess bookingDataAccess = new BookingDataAccess();
                if (bookingDataAccess.AddBooking(booking))
                {
                    MessageBox.Show("Booking Added successfully");
                }
                else
                {
                    MessageBox.Show("Error in Booking");
                }
            }
        }
    }
}
