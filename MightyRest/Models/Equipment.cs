using System;
using System.Collections.Generic;

namespace MightyRest.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            StationsEquipment = new HashSet<StationsEquipment>();
        }

        public int Serialnumber { get; set; }
        public string Name { get; set; }
        public DateTime Purchasedate { get; set; }
        public string Type { get; set; }
        public string Producent { get; set; }
        public DateTime Warrantydate { get; set; }

        public virtual ICollection<StationsEquipment> StationsEquipment { get; set; }
    }
}
