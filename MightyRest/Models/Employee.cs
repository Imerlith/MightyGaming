using System;
using System.Collections.Generic;

namespace MightyRest.Models
{
    public partial class Employee
    {
        //public Employee()
        //{
        //    Assignments = new HashSet<Assignments>();
        //}

        public int Idemployee { get; set; }
        public DateTime Hiredate { get; set; }
        public int PersonIdperson { get; set; }

        public virtual Person PersonIdpersonNavigation { get; set; }
        //public virtual ICollection<Assignments> Assignments { get; set; }
    }
}
