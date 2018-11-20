using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string BloodType { get; set; }
        public List<Consultation> Consultation { get; set; }
        public List<Test> Test { get; set; }
        public List<Medication> Medication { get; set; }

        public int Age
        {
            get
            {
                return System.DateTime.Now.Year - Birthday.Year;
            }
        }
    }
}
