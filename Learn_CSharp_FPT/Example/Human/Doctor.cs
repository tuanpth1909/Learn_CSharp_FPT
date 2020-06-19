using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Human
{
    class Doctor : Person
    {
        public void Display()
        {
            Console.WriteLine("Ten cua toi la: {0}", name);
            Console.WriteLine("Tuoi cua toi la: {0}", age);
            Console.WriteLine("Dia cua toi la: {0}", address);
            Console.WriteLine("So dien thoai cua toi la: {0}", phone);
            Console.WriteLine("Email cua toi la: {0}", email);
        }
    }
}
