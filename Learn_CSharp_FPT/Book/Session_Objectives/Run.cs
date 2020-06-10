using Learn_CSharp_FPT.CodeLean.AP_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Learn_CSharp_FPT.Book.Session_Objectives.GeometricObject;

namespace Learn_CSharp_FPT.Book.Session_Objectives
{
    class Run
    {
        public static void Test()
        {
            //Car car = new Car();
            //Car myCar;
            //System.Console.WriteLine("Creating a Car object and assigning" + "its memory location to myCar");
            //myCar = new Car();
            //myCar.make = "Toyota";
            //myCar.model = "MR2";
            //myCar.color = "black";
            //myCar.yearBuilt = 1995;

            //System.Console.WriteLine("myCar details:");
            //System.Console.WriteLine("myCar.make" + myCar.make);
            //System.Console.WriteLine("myCar.model" + myCar.make);
            //System.Console.WriteLine("myCar.make" + myCar.make);
            //System.Console.WriteLine("myCar.make" + myCar.make);

            //myCar.Start();
            //myCar.Stop();

            //System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to redPorsche");
            //Car redPorsche = new Car();
            //redPorsche.make = "Porsche";
            //redPorsche.model = "Boxster";
            //redPorsche.color = "red";
            //redPorsche.yearBuilt = 2000;
            //System.Console.WriteLine("Assigning redPorsche is a" + redPorsche.model);
            //System.Console.WriteLine("Assigninig redPorsche to myCar");
            //myCar = redPorsche;
            //System.Console.WriteLine("myCar details:");
            //System.Console.WriteLine("myCar.make" + myCar.make);
            //System.Console.WriteLine("myCar.model" + myCar.model);
            //System.Console.WriteLine("myCar.color" + myCar.color);
            //System.Console.WriteLine("myCar.yearBuilt" + myCar.yearBuilt);

            //myCar = null;
            //Console.ReadLine();

            // GeometricObject
            //Circle c1 = new Circle(2.45, "Blue", 23);
            //Console.WriteLine("Circle before change:" + c1.ToString());

            //c1.PColor = "red";
            //c1.PWeight = 2.56;

            //Console.WriteLine("Circle after change:" + c1.ToString());
            //Console.ReadLine();

            //IndexerExample
            int i, j = 0;
            IndexerExample indexTest = new IndexerExample();
            for(i = 1; j < 10; i += 2)
            {
                indexTest[j] = i;
                j++;
            }
            for(i = 0; i < 10; i += 2)
            {
                Console.WriteLine("indexTest[{0}] is {1}", i, indexTest[i]);
                Console.ReadLine();
            }
        }
    }  
}
