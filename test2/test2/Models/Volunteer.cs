using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Volunteer
    {
        public int IdVolunteer { get; set; }
        public int IdSupervisor { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime StartingDate { get; set; }

        public virtual Volunteer IdSupervisorNavigation { get; set; }

    }
}
