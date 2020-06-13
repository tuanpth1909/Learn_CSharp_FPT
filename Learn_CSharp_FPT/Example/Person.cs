using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    public class Person
    {
        //Khai bao thuoc tinh hay khai bao bien
        public string name;
        public int age;
        public DateTime birth;
        public string sex;
        public int phone;
        public string email;
        public string address;
        public string social;

        public void Display()
        {
            Console.WriteLine(this.name + " " + this.age + " " + this.birth + " " + this.sex + " " + this.phone + " " + this.email + " " + this.address + " " + this.social);
        }

        //public void SetName(string ten)
        //  {
        //      name = ten;
        //  }
    }
}
