using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    class Catfish : Animal
    {
        public void Face()
        {
            Console.WriteLine("Khuon mat dep trai, mom giong con ca tre... doi mat long lang");
        }
        public override void AnimalSound()
        {
            Console.WriteLine("cai ma bo thag TU");
        }
        public override void Hatbitat()
        {
            Console.WriteLine("Thu vien");
        }
    }
}
