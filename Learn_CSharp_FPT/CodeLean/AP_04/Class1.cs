using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.AP_04
{
    public static class Class1
    {
        public static void Run()
        {
            ex1();
            ex2();
            ex3();
            ex4();
        }
        static void ex1()
        {
            string response = "Yes";
            if(response == "Yes")
            {
                //statemets that will execute if the value of the response variable is
                //yes, will be placed here.
            }
        }
        static void ex2()
        {
            string response = "connection_failed";
            if(response == "connection_failed")
            {
                //
            }
            else
            {
                //
            }
        }
        static void ex3()
        {
            string response = "Yes";
            if(response == "Yes")
            {
                //
            }
            else if(response == "connection_failed"){
                //
            }
            else
            {
                //
            }
        }
        static void ex4()
        {
            string response = "Yes";
            switch (response)
            {
                case "Yes":
                    //Block of code executes if the value of response is "Yes".
                    break;
                case "connection_failed":
                    //Block of code executes if the value of response is "connection_failed".
                    break;
                case "connection_error":
                    //Block of code executes if the value of response is "connection_error".
                    break;
                default:
                    //
                    break;

            }
        }
    }
}
