using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class Extras
    {
        public int Idextras { get; set; }
        public int BookingIdbooking { get; set; }
        public int OrderIdorder { get; set; }

        public virtual Booking BookingIdbookingNavigation { get; set; }
        public virtual Order OrderIdorderNavigation { get; set; }
    }
}
