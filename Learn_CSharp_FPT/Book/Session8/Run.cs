using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    class Run
    {
        public static void Test()
        {
            //dog
            Dog dog = new Dog();
            dog.AnimalSound();
            dog.Hatbitat();
            Console.WriteLine("\n");

            //Tu
            Catfish TU = new Catfish();
            TU.AnimalSound();
            TU.Face();
            TU.Hatbitat();
            Console.WriteLine("\n");

            //dog
            dogs objDog = new dogs();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
            Console.WriteLine("\n");

            //Crocodile
            Crocodile objCrocodile = new Crocodile();
            objCrocodile.Eat();
            objCrocodile.Swim();

            //Employee
            Employee objEmployee = new Employee();
            objEmployee.AcceptDetails(10, "Jack");
            IGet objGet = objEmployee as IGet;
            if(objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }

            //Rectangle
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
            if(objRectangle is ICalculate)
            {
                Console.WriteLine("Area of rectangle: {0:F2}",objRectangle.Area());
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }

            //Circle
            Sphere objSphere = new Sphere();
            objSphere.Radius = 7;
            objSphere.Area();
            Console.WriteLine("Area of Sphere: {0 : F2}", objSphere.areaOfSphere);
        }
    }
}
