using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class StationsBookings
    {
        public int Id { get; set; }
        public int BookingIdbooking { get; set; }
        public int StationStationnumber { get; set; }

        public virtual Booking BookingIdbookingNavigation { get; set; }
        public virtual Station StationStationnumberNavigation { get; set; }
    }
}
