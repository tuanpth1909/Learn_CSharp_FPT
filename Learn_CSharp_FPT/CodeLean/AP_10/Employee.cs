using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_10
{
    class Employee
    {
        private string name;
        private double baseSalary;
        private int Id;
        private static int employeeCount = 1;

        public Employee(string name, double baseSalary)
        {
            this.name = name;
            this.baseSalary = baseSalary;
            this.Id = employeeCount++;
        }
        public string Name
        {
            get; set;
        }
        public double BaseSalary
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
        public double getBaseSalary()
        {
            return this.baseSalary;
        }
        public string getName()
        {
            return this.name;
        }
        public int getID()
        {
            return this.Id;
        }
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        public virtual string employeeStatus()
        {
            return toString() + "is in the company's system";
        }
    }
}
