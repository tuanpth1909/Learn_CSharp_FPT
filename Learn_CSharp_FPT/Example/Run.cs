
using Learn_CSharp_FPT.Example.Human;
using Learn_CSharp_FPT.Example.Write;
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
            Doctor myDoctor = new Doctor();
            myDoctor.Display();
        }

        public static void Test5()
        {
            Actor myActor = new Actor();
            myActor.XinChao();
            myActor.Chay();
        }

        public static void Test6()
        {
            Studentt myStudent = new Studentt();

            //myStudent.StudentID = 5763468;
            Console.WriteLine(myStudent.StudentID);

            myStudent.Name = "Pham Tuan";
            myStudent.GPA = 10;
            myStudent.Display();
        }

        public static void Test7()
        {
            Books myBooks = new Books("Learn C# in 21 Days", 1240);
            Console.WriteLine("Book Name: {0}", myBooks.BookName);
            Console.WriteLine("Book ID:" + myBooks.BookID);
        }

        public static void Test8()
        {
            Product myProduct = new Product();
            myProduct.ProductName = "Meeting";
            myProduct.ProductID = 20;
            myProduct.Price = -54.3F;
            Console.WriteLine("Product Name: {0}", myProduct.ProductName);
            Console.WriteLine("Product ID: {0}", myProduct.ProductID);
            Console.WriteLine("Price: {0}", myProduct.Price);
        }


        public static void Test9()
        {
            PTB2 ptb2 = new PTB2();
            ptb2.NhapAbc();
            ptb2.GiaiPT();
            ptb2.XuatKQ();
        }
    }
}
