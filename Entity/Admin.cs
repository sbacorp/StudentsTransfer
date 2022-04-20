using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTransfer.Entity
{
    public class Admin : User
    {
        public Admin(string login, string pass) : base(login, pass) { }
    }
}
