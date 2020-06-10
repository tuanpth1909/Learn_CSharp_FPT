using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session_Objectives
{
   public abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        protected GeometricObject()
        {
            color = "white";
            weight = 1.0;
        }
        protected GeometricObject (string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public string PColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double PWeight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public abstract double findArea();
        public abstract double findPerimeter();
        public class Circle : GeometricObject
        {
            private double radius;
            public Circle(double x)
            {
                this.radius = x;
            }
            public Circle(double x, string c, double w) : base(c, w) 
            {
                this.radius = x;
            }
            public override string ToString()
            {
                return "Circle has: radius is" + radius + ", color is " + PColor + ", weight is" + PWeight;
            }
            public override double findArea()
            {
                return Math.PI * radius * radius;
            }
            public override double findPerimeter()
            {
                return 2 * Math.PI * radius;
            }
        }
    }
}
