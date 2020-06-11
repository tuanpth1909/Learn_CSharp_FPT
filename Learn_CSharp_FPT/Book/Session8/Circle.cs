using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session8
{
    interface IMath
    {
        void Area();
    }
    class Circle
    {
        public const float PI = 3.14F;
        public float Radius;
        public double AreaOfCircle;
        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }
    class Sphere : Circle
    {
       public double areaOfSphere;
        public override void Area()
        {
            base.Area();
            areaOfSphere = (AreaOfCircle * 4);
        }
    }
}
