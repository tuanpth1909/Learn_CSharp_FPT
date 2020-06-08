using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session6
{
     class Student
    {
         string StudName = "James Anderson";
         int StudAge = 27;

         public void Display()
        {
            Console.WriteLine("Student Name:" + StudName);
            Console.WriteLine("Student Age:" + StudAge);
        }
    }
}

