using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session7
{
    class newAnimals
    {
        public newAnimals()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public newAnimals(string name)
        {
            Console.WriteLine("Animal constructor with a string parameters");
        }
    }
    class Canine : newAnimals
    {
        //base() tale a string value called "Lion"
        public Canine() : base("Lion"){
            Console.WriteLine("Dericed Canine");
        }
    }
  
}
