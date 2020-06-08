using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.CodeLean.Ap_05
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
            //for Loop
            for(int i = 0; i < 10; i++)
            {
                //code to execute
            }
        }
        static void ex2()
        {
            string[] names = new string[10];
            //Process each name in the array.
            foreach (string name in names)
            {
                //code to execute
            }
        }
        static void ex3()
        {
            //while loop
            string response = PromptUser();
            while (response != "Quit")
            {
                //Process the data
                response = PromptUser();
            }
        }

        private static string PromptUser()
        {
            throw new NotImplementedException();
        }

        static void ex4()
        {
            string response;

            //do Loop
            do
            {
                //Process the data
                response = PromptUser();
            }
            while (response != "Quit");
        }
    }
}
