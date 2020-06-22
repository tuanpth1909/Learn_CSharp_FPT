using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_10
{
    class Technical : Employee
    {
        private int successfulCheckIns = 100;
        public Technical(String name) : base(name, 75000)
        {
          
        }
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins ";
        }
    }
}
