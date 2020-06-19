using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    public abstract class Snippet6
    {
        public abstract float DimensionOne
        {
            set;
        }
        public abstract float DimensionTwo
        {
            set;
        }
    }
    class Rectangle : Snippet6
    {
        float _dimensionOne;
        float _dimensionTwo;
        public override float DimensionOne
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionOne = 0;
                }
                else
                {
                    _dimensionOne = value;
                }
            }
        }
        public override float DimensionTwo
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionTwo = 0;
                }
                else
                {
                    _dimensionTwo = value;
                }
            }
        }
        public float Area()
        {
            return _dimensionOne * _dimensionTwo;
        }
    }
}
