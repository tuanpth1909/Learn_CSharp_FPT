using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session7
{
    class Employee
    {
        int empid = 1;
        string empName = "James Anderson";
        int age = 25;
        
        public void Display()
        {
            Console.WriteLine("Employee ID:" + empid);
            Console.WriteLine("Employee Name:" + empName);
        }
    }
    class Deparment : Employee
    {
        int deptId = 501;
        string deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Deparment ID:" + deptId);
            Console.WriteLine("Deparment Name:" + deptName);
        }
    }
}
