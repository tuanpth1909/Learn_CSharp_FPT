using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Lab
{
    class Employee
    {
        //Tao thuoc tinh
        public string firstName;
        public string lastName;
        public string address;
        public long sin;
        public double salary;

        //Tao Constructor
        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        //Tao phung thuc
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = lastName;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                this.address = address;
            }
        }
        public long Sin
        {
            get
            {
                return sin;
            }
            set
            {
                this.sin = sin;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                this.salary = salary;
            }
        }
    }
}
