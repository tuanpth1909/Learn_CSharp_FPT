using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Square : Figure
    {
        public static void HinhVuong()
        {
            Square mySquare = new Square();
            mySquare.CD = 20;
            mySquare.CR = 50;
            mySquare.ChuVi();
            mySquare.DienTIch();
        }
    }
}
