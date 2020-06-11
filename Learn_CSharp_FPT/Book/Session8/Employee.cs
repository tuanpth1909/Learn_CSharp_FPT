using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    interface ISet
    {
        void AcceptDetails(int valOne, string valTwo);
    }
    interface IGet{
        void Display();
    }
    class Employee : ISet 
    {
        int empID;
        string empName;
        public void AcceptDetails (int valOne, string valTwo)
        {
            empID = valOne;
            empName = valTwo;
        }
    }
}
