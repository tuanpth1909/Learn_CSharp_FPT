
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    class Snippet11
    {
        string _carType;
        public virtual string CarType
        {
            get
            {
                return _carType;
            }
            set
            {
                _carType = value;
            }
        }
    }
    class Ferrari : Snippet11
    {
        string _carType;
        public override string CarType
        {
            get
            {
                return base.CarType;
            }
            set
            {
                base.CarType = value;
                _carType = value;
            }
        }
   
    }
}
