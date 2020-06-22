using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class Order
    {
        public Order()
        {
            Extras = new HashSet<Extras>();
        }

        public int Idorder { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<Extras> Extras { get; set; }
    }
}
