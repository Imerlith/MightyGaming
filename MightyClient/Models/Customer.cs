using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
        }

        public int Idcustomer { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public int PersonIdperson { get; set; }

        public virtual Person PersonIdpersonNavigation { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
