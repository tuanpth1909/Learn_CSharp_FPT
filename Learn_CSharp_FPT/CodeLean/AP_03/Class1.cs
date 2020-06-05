using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_03
{
    public static class Class1
    {
        public static void Run()
        {
            Dtc_1();
            Dtc_2();
            Dtc_3();
            Dtc_4();
        }
        static void Dtc_1()
        {
            int myInt = 654354554;
            long myLong = myInt;
        }
        static void Dtc_2()
        {
            double myDouble = 1234.5;
            int myInt;
            myInt = (int)myDouble;
        }
        static void Dtc_3()
        {
            double myDouble = 123.4;
            int myInt;
            myInt = Convert.ToInt32(myDouble);
        }
        static void Dtc_4()
        {
            //TryParse() example
            bool result = Int32.TryParse(222, out 533454);
            //Parse() example
            int number = Int32.Parse(value);
        }
    }
   
}
