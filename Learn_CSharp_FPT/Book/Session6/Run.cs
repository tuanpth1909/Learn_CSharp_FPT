using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session6
{
    class Run
    {
        public static void Test()
        {
            //Bai 1
            Student student = new Student();
            student.Display();


            //Bai 2
            Book objBook = new Book();
            objBook.Input("C# - The Complete REference");
            Console.WriteLine(objBook.Print());

            //Bai 3
            Student01 student01 = new Student01();
            student01.printName("Henry", "Parker");
            student01.printName(firstName: "Henry", lastName: "Parker");
            student01.printName(lastName: "Parker", firstName: "Henry");
            student01.printName("Henry", lastName: "Parker");

            //Bai 4
            Product product = new Product();
            Product.Dislpay();
            Console.ReadKey();
        }

    }
}
