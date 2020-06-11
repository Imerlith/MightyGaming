using System;
using System.Collections.Generic;

namespace MightyRest.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Assignments = new HashSet<Assignments>();
            Extras = new HashSet<Extras>();
            StationsBookings = new HashSet<StationsBookings>();
        }

        public int Idbooking { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public int Opinion { get; set; }
        public string Notes { get; set; }
        public int Requiredemployees { get; set; }
        public int Numberofpeople { get; set; }
        public decimal Cost { get; set; }
        public int CustomerIdcustomer { get; set; }

        public virtual Customer CustomerIdcustomerNavigation { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Extras> Extras { get; set; }
        public virtual ICollection<StationsBookings> StationsBookings { get; set; }
    }
}
