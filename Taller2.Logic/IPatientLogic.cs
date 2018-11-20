using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Logic
{
    public interface IPatientLogic
    {
        List<Patient> GetPatient(string name, string userName, DateTime conclusionDate);
    }
}
