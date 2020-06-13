using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    class Run
    {
        public static void Display()
        {
            Employee emp = new Employee();
            emp.Name = "John Doe";
            emp.Age = 24;
            emp.Designation = "Sales Person";
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", emp.Name, emp.Age, emp.Designation);
        }
    }
}
