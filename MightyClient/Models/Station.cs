using System;
using System.Collections.Generic;

namespace MightyClient.Models
{
    public partial class Station
    {
        public Station()
        {
            StationsBookings = new HashSet<StationsBookings>();
            StationsEquipment = new HashSet<StationsEquipment>();
        }

        public int Stationnumber { get; set; }
        public string Specialization { get; set; }
        public DateTime Inspectiondate { get; set; }

        public virtual ICollection<StationsBookings> StationsBookings { get; set; }
        public virtual ICollection<StationsEquipment> StationsEquipment { get; set; }

        public override string ToString()
        {
            return Stationnumber + " - " + Specialization;
        }
    }
}
