using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session7
{
    class Run
    {
        public static void Test()
        {
            //bai 1
            Dog objdog = new Dog();
            objdog.Eat();
            objdog.Feature();
            objdog.Noise();

            //bai 2
            Cats objCat = new Cats();
            objCat.Food = "Mouse";
            objCat.Activity = "lazearound";
            Console.WriteLine("The Cat loves to eats" + objCat.Food + ".");
            Console.WriteLine("The Catloves to" + objCat.Activity + ".");

            //bai 3
            Deparment objDeparment = new Deparment();
            objDeparment.Display();

            //bai 4
            Canine objCanine = new Canine();
        }
           
    }
}
