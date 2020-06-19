using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Learn_CSharp_FPT.Example
{
    class PTB2
    {
        //Tao cac truong co trong class
        static double a, b, c;
        static double x1, x2;
        static double delta;

        //Nhap a, b, c cua PTB 2
       public void NhapAbc()
        {
            string obj;
            Console.WriteLine("Nhap a:"); obj = Console.ReadLine();
            a = Double.Parse(obj);
            Console.WriteLine("Nhap b:"); obj = Console.ReadLine();
            b = Double.Parse(obj);
            Console.WriteLine("Nhap c:"); obj = Console.ReadLine();
            c = Double.Parse(obj);
        }

        //Dinh nghia ham tinh nghiem cua PT b2
        public void GiaiPT()
        {
            //Tinh delta de giai PT
            delta = b * b - 4 * a * c;
            if(delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 / a;
                x2 = (-b - Math.Sqrt(delta)) / 2 / a;
            }
        }

        //Dinh nghia ket qua
        public void XuatKQ()
        {
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem thuc la:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
