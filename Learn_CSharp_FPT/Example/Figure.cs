using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example
{
    class Figure
    {
        public int CD;
        protected int CR;
        protected int CV;
        protected double DT;

        //public Figure(int CD, int CR)
        //{
        //    this.CD = CD;
        //    this.CR = CR;
        //    //this.CV = CV;
        //    //this.DT = DT;
        //}

        //public int CDai
        //{
        //    get
        //    {
        //        return CD;
        //    }
        //    set
        //    {
        //        CD = value;
        //    }
        //}
        //public int CRong
        //{
        //    get
        //    {
        //        return CR;
        //    }
        //    set
        //    {
        //        CR = value;
        //    }
        //}
        //public int CVi
        //{
        //    get
        //    {
        //        return CV;
        //    }
        //    set
        //    {
        //        CV = value;
        //    }
        //}
        //public double DTich
        //{
        //    get
        //    {
        //        return DT;
        //    }
        //    set
        //    {
        //        DT = value;
        //    }
        //}

        public void ChuVi()
        {
            CV = (CD + CR) * 2;
            Console.WriteLine("Chu vi cua hinh la: {0}", CV);
        }
        public void DienTIch()
        {
            DT = CD * CR;
            Console.WriteLine("Dien tich cua hinh la: {0}", DT);
        }
    }
}
