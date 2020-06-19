using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Human
{
    abstract class Person
    {
        //protected string name;
        //protected int age;
        //protected string address;
        //protected string phone;
        //protected string email;

        public void XinChao()
        {
            Console.WriteLine("Xin chao tat ca moi nguoi");
        }
        protected string name = Console.ReadLine();
        protected int age = Convert.ToInt32(Console.ReadLine());
        protected string address = Console.ReadLine();
        protected string phone = Console.ReadLine();
        protected string email = Console.ReadLine();
    }
}
