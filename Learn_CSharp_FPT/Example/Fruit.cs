using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Fruit
    {
        protected string color;
        public void Talk(string name)
        {
            Console.WriteLine("toi la: {0}", name);
        }
        public void hello()
        {
            Console.WriteLine("Xin chao tat ca mn");
        }
        public void SetColor(string mau)
        {
            color = mau;
        }
    }
}
