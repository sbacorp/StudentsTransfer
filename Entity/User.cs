using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTransfer.Entity
{
    abstract public class User
    {
        public string login { get; private set; }
        public string password { get; private set; }
    }
}
