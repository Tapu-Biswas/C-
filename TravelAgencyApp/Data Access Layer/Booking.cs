using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Data_Access_Layer
{
    class Booking
    {
        public int BookingOrderId { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public string Country { get; set; }
        public string Flight { get; set; }
        public string Hotel { get; set; }
        public string DesirablePlace { get; set; }
        public string TourRide { get; set; }
        public string Person { get; set; }
        public string TotalCost { get; set; }
        public string PayOption { get; set; }
        public string Status { get; set; }
    }
}
