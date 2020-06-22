using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_11
{
    class Technical : Employee
    {
        private static int successfulCheckIns = 10;

        public Technical(string name) : base(name, 5500)
        {

        }
        //public override string employeeStatus()
        //{
        //    return this.toString() + " has " + this.successfulCheckIns + " successful check ins ";
        //}
    }
}
