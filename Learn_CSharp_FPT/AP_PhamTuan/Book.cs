using System;
using System.Collections.Generic;
using System.Text;

namespace AP_PhamTuan
{
    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base(id, name, price, producer)
        {

        }
        public override double computeTax()
        {
            return price * 0.08;
        }
    }
}
