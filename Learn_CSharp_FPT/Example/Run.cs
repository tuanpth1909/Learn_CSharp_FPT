using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Run
    {
        public static void Test1()
        {   
            Console.WriteLine("Tu khoa sizeof trong C#");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Kich thuoc cua kieu du lieu int la: {0}", sizeof(int));
            Console.WriteLine("Kich thuoc cua kieu du lieu float la: {0}", sizeof(float));
            Console.WriteLine("Kich thuoc cua kieu du lieu double la: {0}", sizeof(double));
            Console.ReadLine();
             
        }
        public static void Test2()
        {
            Person myPerson = new Person();
            myPerson.name = "Tuan";
            myPerson.age = 19;
            myPerson.sex = "male";
            myPerson.phone = 0382548442;
            myPerson.address = "90 Nguyen Tuan - Thanh Xuan - Ha Noi";
            myPerson.Display();

            Student myStudent = new Student();
            myStudent.phone = 0333612668;
            myStudent.address = "San bong ME TRI THUONG";
            myStudent.Display();
            myStudent.name = "Nam";
            myStudent.age = 20;
            myStudent.sex = "male";
            
        }
        public static void Test3()
        {
            Apple myApple = new Apple();
            myApple.Talk("TAo");
            myApple.hello();
            myApple.SetColor("green");
            myApple.Mau();
            Console.ReadKey();
        }
        public static void Test4()
        {

        }
    }
}
