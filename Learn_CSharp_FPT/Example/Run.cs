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
    }
}
