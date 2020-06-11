using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog bark");
        }
        public override void Hatbitat()
        {
            Console.WriteLine("At home or Jungle");
        }
    }
}
