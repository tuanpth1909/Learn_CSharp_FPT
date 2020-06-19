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
        public static void Display2()
        {
            Snippet10 emp1 = new Snippet10
            {
                Name = "John Doe",
                Age = 24,
                Designation = "Sales Person"
             };
            Console.WriteLine("Name: { 0}, Age: { 1}, Designation: { 2}",
                  emp1.Name, emp1.Age, emp1.Designation);
        }

        public static void Display3()
        {
            Snippet11 objCar = new Snippet11();
            objCar.CarType = "Utility Vehicle";
            Ferrari objFerrari = new Ferrari();
            objFerrari.CarType = "Sports Car";
            Console.WriteLine("Car Type: " +objCar.CarType);
            Console.WriteLine("Ferrari Car Type: " +
            objFerrari.CarType);
        }

        class SalaryDetails : Snippet7
        {
            public static void Display4()
            {
                SalaryDetails objSalary = new SalaryDetails();
                objSalary.EmpName = "Frank";
                objSalary.EmpID = 10;
                objSalary.Salary = 1000.25F;
                Console.WriteLine("Name: " +objSalary.EmpName);
                Console.WriteLine("ID: " +objSalary.EmpID);
                Console.WriteLine("Salary: " +objSalary.Salary + "$");
            }

            public static void Display5()
            {
                Rectangle objRectangle = new Rectangle();
                objRectangle.DimensionOne = 20;
                objRectangle.DimensionTwo = 4.233F;
                Console.WriteLine("Area of Rectangle: " +objRectangle.Area());
            }

            public static void Display6()
            {
                Snippet5.UniversityName = "University of Maryland";
                Snippet5.Department = "Physics";
                Console.WriteLine("University Name: " +Snippet5.UniversityName);
                Console.WriteLine("Department name: " +Snippet5.Department);
            }

            public static void Display7()
            {
                Snippet4 objProduct = new Snippet4("Hard Disk", 101);
                objProduct.Price = 345.25F;
                objProduct.Display();
            }

            public static void Display8()
            {
                Snippet3 objDepartment = new Snippet3();
                objDepartment.DeptID = 201;
                objDepartment.DeptName = "Sales";
                objDepartment.Display();
            }

            public static void Display9()
            {
                Snippet2 objBook = new Snippet2("Learn C# in 21 Days", 10015);
                Console.WriteLine("Book Name: " +objBook.BookName);
                Console.WriteLine("Book ID: " +objBook.BookID);
            }

            public static void Display10()
            {
                Snippet1 objSal = new Snippet1();
                objSal.EmployeeName = "Patrick Johnson";
                Console.WriteLine("Employee Name: " +objSal.EmployeeName);
            }
        }
    }
}
