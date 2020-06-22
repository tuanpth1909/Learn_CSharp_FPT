using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_11
{
    abstract class Employee
    {
        //khai bao bien
        private int id;
        private string name;
        private double baseSalary;
        private static int idcount = 1;

        //tao constructor
        public Employee(string name, double baseSalary)
        {
            this.name = name;
            this.baseSalary = baseSalary;
            this.id = idcount++;
        }

        //tao ham cac properties
        public string Name
        {
            get;set;
        }
        public double BaseSalary
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }
        public string getName() 
        {
            return this.name;
        }
        public double getBaseSalary()
        {
            return this.baseSalary;
        }
        public int getId()
        {
            return this.id;
        }
        
        //tao methods tra ve mot chuoi 
        public string toString()
        {
            return this.id + " " + this.name;
        }
        //tao method tra ve gia tri ho co trong he thong 
        public virtual string EmployeeStatus()
        {
            return toString() + "is in company's of system";
        }
    }
}
