using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Rectangle : Figure
    {
        public static void Tinh()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.CD = 10;
            myRectangle.CR = 5;
            myRectangle.ChuVi();
            myRectangle.DienTIch();
        }
    }
}
