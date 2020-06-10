using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session7
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
    }
    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }
    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks");
        }
    }
}
