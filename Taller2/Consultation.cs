using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public class Consultation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Doctor { get; set; }
        public string Symptoms { get; set; }
    }
}