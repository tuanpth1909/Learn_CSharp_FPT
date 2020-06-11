using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float lenght;
        float breadth;
        public Rectangle(float valOne, float valTwo)
        {
            lenght = valOne;
            breadth = valTwo;
        }
        public double Area()
        {
            return lenght * breadth;
        }

    }
}
