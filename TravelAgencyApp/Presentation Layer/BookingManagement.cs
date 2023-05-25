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
    public partial class BookingManagement : Form
    {
        public BookingManagement()
        {
            InitializeComponent();
        }

        private void BookingManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbookbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Login.globalUser);
            dashboard.Show();
            this.Hide();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            UpdateBookingList();
        }

        void UpdateBookingList()
        {
            BookingDataAccess bookingDataAccess = new BookingDataAccess();
            bookingdataGridView.DataSource = bookingDataAccess.GetAllBookings();
        }

        private void deletebookbutton_Click(object sender, EventArgs e)
        {
            BookingDataAccess bookingDataAccess = new BookingDataAccess();
            if (bookingDataAccess.DeleteBooking(Convert.ToInt32(deletebooktextBox.Text)))
            {
                MessageBox.Show("Bookings deleted");
                UpdateBookingList();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
        }

        private void searchbookbutton_Click(object sender, EventArgs e)
        {
            BookingDataAccess bookingDataAccess = new BookingDataAccess();
            bookingdataGridView.DataSource = bookingDataAccess.GetBookingDetailsById(Convert.ToInt32(searchbooktextBox.Text));
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            UpdateBookingList();
        }

        private void Updateempbutton_Click(object sender, EventArgs e)
        {
            BookingDataAccess bookingDataAccess = new BookingDataAccess();
            if (bookingDataAccess.UpdateBooking(Convert.ToInt32(bookingtextBox.Text),Convert.ToInt32(customertextBox.Text), datedateTimePicker.Text, countrytextBox.Text, flightcomboBox.Text, hotelcomboBox.Text, desirableplacetextBox.Text, tourridecomboBox.Text, persontextBox.Text, totalcosttextBox.Text, payoptioncomboBox.Text, statuscomboBox.Text))
            {
                MessageBox.Show("Booking updated");
                UpdateBookingList();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }
    }
}
