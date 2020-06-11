using System;
using System.Collections.Generic;

namespace MightyRest.Models
{
    public partial class StationsEquipment
    {
        public int Id { get; set; }
        public int StationStationnumber { get; set; }
        public int EquipmentSerialnumber { get; set; }

        public virtual Equipment EquipmentSerialnumberNavigation { get; set; }
        public virtual Station StationStationnumberNavigation { get; set; }
    }
}
