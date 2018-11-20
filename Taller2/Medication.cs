using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public class Medication
    {
        public int Id { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public DateTime ConclusionDate { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
    }
}