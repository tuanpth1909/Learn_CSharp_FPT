using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Human
{
    class Actor : Person
    {
        public void Chay()
        {
            Console.WriteLine("TOi con nhie hon the nay");
            Console.WriteLine(this.name + " " + this.age + " " + this.address + " " + this.phone + " " + this.email);
        }
    }
}
