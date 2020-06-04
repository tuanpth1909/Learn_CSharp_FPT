using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT
{
    class Program
    {
        static void Main(string[] args)
        {
            CS1();
            //cs2();
            //cs3();
            //cs4();
            //cs5();
            //cs6();
            //cs7();
            //cs8();
            //cs9();
            //cs10();
            //cs11();
            //cs12();
            //cs13();
            //cs14();
            //cs15();
            //cs16();
            //cs17();
            //cs18();
            //cs19();
            //cs20();
            //cs21();
        }

        static void CS1()
        {
            int empNumber;
            string empName;
        }
        static void CS2()
        {
            bool boolTest = true;
            short byteTest = 19;
            int intTest;
            string stringTest = “David”;
            float floatTest;
            intTest = 140000;
            floatTest = 14.5f;
            Console.WriteLine(“boolTest = { 0}”, boolTest);
            Console.WriteLine(“byteTest = ” +byteTest);
            Console.WriteLine(“intTest = ” +intTest);
            Console.WriteLine(“stringTest = ” +stringTest);
            Console.WriteLine(“floatTest = ” +floatTest);
        }
        static void CS3()
        {
            var boolTest = true;
            var byteTest = 19;
            var intTest = 140000;
            var stringTest = “David”;
            var floatTest = 14.5f;
            Console.WriteLine(“boolTest = { 0}”, boolTest);
            Console.WriteLine(“byteTest = ” +byteTest);
            Console.WriteLine(“intTest = ” +intTest);
            Console.WriteLine(“stringTest = ” +stringTest);
            Console.WriteLine(“floatTest = ” +floatTest);
        }
        static void CS4()
        {
            // This block of code will add two numbers
            int doSum = 4 + 3;
        }
        static void CS5()
        {
            /* This is a block of code that will multiply two numbers,
divide the resultant value by 2 and display the quotient */
            int doMult = 5 * 20;
            int doDiv = doMult / 2;
            Console.WriteLine(“Quotient is:” +doDiv)
        }
        static void CS6()
        {
            /// <summary>
            /// You are in the XML tag called summary.
            /// </summary>
        }
        static void CS7()
        {
            /// <summary>
/// The program demonstrates the use of XML comments.
///
/// Employee class uses constructors to initialize the ID and
/// name of the employee and displays them.
/// </summary>
/// <remarks>
/// This program uses both parameterized and
/// non-parameterized constructors.
/// </remarks>
class Employee
        {
            /// <summary>
            /// Integer field to store employee ID.
            /// </summary>
            /// private int _id;
            /// <summary>
            /// String field to store employee name.
            /// </summary>
            private string _name;
            /// <summary>
            /// This constructor initializes the id and name to -1 and null.
            /// </summary>
            /// <remarks>
            /// <seealsocref=”Employee(int,string)”>Employee(int,string)</ seealso>
            /// </remarks>
            public Employee()
            {
                _id = -1;
                _name = null;
            }
            /// <summary>
            /// This constructor initializes the id and name.
            /// (<paramref name=”id”/>,<paramref name=”name”/>).
            /// </summary>
            /// <param name=”id”>Employee ID</param>
            /// <param name=”name”>Employee Name</param>
            public Employee(int id, string name)
            {
                this._id = id;
                this._name = name;
            }
            /// <summary>
            /// The entry point for the application.
            /// <param name=”args”>A list of command line arguments</param>
            /// </summary>
            static void Main(string[] args)
            {
                // Creating an object of Employee class and displaying the
                // id and name of the employee
                Employee objEmp = new Employee(101, “David Smith”);
                Console.WriteLine(“Employee ID: { 0} \nEmployee Name : { 1}”,
objEmp._name);
            }
            static void CS8()
            {
                const float _pi = 3.14F;
                float radius = 5;
                float area = _pi * radius * radius;
                Console.WriteLine(“Area of the circle is ” +area);
            }
            static void CS9()
            {
                string str = “\u0048\u0065\u006C\u006C\u006F”;
                Console.Write(“\t” +str + “!\n”);
                Console.WriteLine(“David\u0020\”2007\” “);
            }
            static void CS10()
            {
                string path = “C:\\Windows\\MyFile.txt”;
                bool found = true;
                if (found)
                {
                    Console.WriteLine(“File path: \’” +path + “\’”);
                }
                else
                {
                    Console.WriteLine(“File Not Found!\a”);
                }
            }
            static void CS11()
            {
                Console.WriteLine(“C# is a powerful programming language”);
Console.WriteLine(“C# is a powerful”);
Console.WriteLine(“programming language”);
                Console.Write(“C# is a powerful”);
Console.WriteLine(“ programming language”);
            }
            static void CS12()
            {
                int number, result;
                number = 5;
                result = 100 * number;
                Console.WriteLine(“Result is { 0 } when 100 is multiplied by { 1}”, result,number);
                result = 150 / number;
                Console.WriteLine(“Result is { 0 } when 150 is divided by { 1}”, +result, number);
            }
            static void CS13()
            {
                string name;
                Console.Write(“Enter your name: “);
                name = Console.ReadLine();
                Console.WriteLine(“You are { 0}”,name);
            }
            static void CS14()
            {
                string custName;
                double loanAmount;
                float interest = 0.09F;
                double interestAmount = 0;
                double totalAmount = 0;
                double totalAmount = 0;
                Console.Write(“Enter the name of the customer: “);
                custName = Console.ReadLine();
                Console.Write(“Enter loan amount: “);
                loanAmount = Convert.ToDouble(Console.ReadLine());
                interestAmount = loanAmount * interest;
                totalAmount = loanAmount + interestAmount;
                Console.WriteLine(“\nCustomer Name: { 0}”, custName);
                Console.WriteLine(“Loan amount: ${
                    0:#,###.#0} \nInterest rate
: {
                        1:0#%} \nInterest Amount : ${2:#,###.#0}”,
loanAmount, interest, interestAmount );
                        Console.WriteLine(“Total amount to be paid: ${
                            0:#,###.#0} “,
totalAmount);
                        }
                        static void CS15()
                        {
                            string userName;
                            int age;
                            double salary;
                            Console.Write(“Enter your name: “);
                            userName = Console.ReadLine();
                            Console.Write(“Enter your age: “);
                            age = Convert.ToInt32(Console.ReadLine());
                            Console.Write(“Enter the salary: “);
                            salary = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(“Name: { 0}, Age: { 1}, Salary: { 2} “, userName, age, salary);
                    }
                    static void CS16()
                    {
                        int num = 456;
                        Console.WriteLine(“{ 0:C}”, num);
                Console.WriteLine(“{ 0:D}”, num);
                Console.WriteLine(“{ 0:E}”, num);
            }
            static void CS17()
            {
                double loanAmount = 15590;
                float interest = 0.09F;
                double interestAmount = 0;
                double totalAmount = 0;
                interestAmount = loanAmount * interest;
                totalAmount = loanAmount + interestAmount;
                Console.WriteLine(“Loan amount: ${
                    0:#,###.#0} “, loanAmount);
Console.WriteLine(“Interest rate: {
                        0:0#%} “, interest);
Console.WriteLine(“Total amount to be paid:${
                            0:#,###.#0}”,totalAmount);
            }
                        static void CS18()
                        {
                            int num = 456;
                            Console.WriteLine(“{ 0:F}”, num);
                    Console.WriteLine(“{ 0:N}”, num);
                    Console.WriteLine(“{ 0:X}”, num);
                }
                static void CS19()
                {
                    DateTime dt = DateTime.Now;
                    // Returns short date (MM/DD/YYYY)
                    Console.WriteLine(“Short date format(d): { 0:d}”, dt);
                // Returns long date (Day, Month Date, Year)
                Console.WriteLine(“Long date format(D): { 0:D}”, dt);
                // Returns full date with time without seconds
                Console.WriteLine(“Full date with time without seconds(f):{ 0:f}”, dt);
                // Returns full date with time with seconds
                Console.WriteLine(“Full date with time with seconds(F):{ 0:F}”, dt);
                // Returns short date and short time without seconds
                Console.WriteLine(“Short date and short time without seconds(g):{ 0:g}”, dt);
            }
            static void CS20()
            {
                DateTime dt = DateTime.Now;
                // Returns short date and short time with seconds
                Console.WriteLine(“Short date and short time with seconds(G):{ 0:G}”, dt);
                // Returns month and day - M can also be used
                Console.WriteLine(“Month and day(m):{ 0:m}”, dt);
                // Returns short time
                Console.WriteLine(“Short time(t):{ 0:t}”, dt);
                // Returns short time with seconds
                Console.WriteLine(“Short time with seconds(T):{ 0:T}”, dt);
                // Returns year and month - Y also can be used
                Console.WriteLine(“Year and Month(y):{ 0:y}”, dt);
            }
            static void CS21()
            {
                DateTime date = DateTime.Now;
                Console.WriteLine(“Date is { 0:ddd MMM dd, yyyy }”, date);
                Console.WriteLine(“Time is { 0:hh: mm tt }”, date);
                Console.WriteLine(“24 hour time is { 0:HH: mm }”, date);
                Console.WriteLine(“Time with seconds: { 0:HH: mm: ss tt}”, date);
                Console.WriteLine(“Day of month: { 0:m}”, date);
                Console.WriteLine(“Year: { 0:yyyy}”, date);
            }

        }
    }
}
