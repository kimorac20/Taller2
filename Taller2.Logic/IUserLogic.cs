using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Logic
{
    interface IUserLogic
    {
        List<Usuario> Login(string userName, string password);
    }
}
