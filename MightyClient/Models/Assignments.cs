using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class Assignments
    {
        public int Idassignments { get; set; }
        public int BookingIdbooking { get; set; }
        public int EmployeeIdemployee { get; set; }

        public virtual Booking BookingIdbookingNavigation { get; set; }
        public virtual Employee EmployeeIdemployeeNavigation { get; set; }
    }
}
