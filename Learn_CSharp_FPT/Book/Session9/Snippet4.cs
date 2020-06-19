using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    class Snippet4
    {
        string _productName;
        int _productID;
        float _price;
        public Snippet4(string name, int val)
        {
            _productName = name;
            _productID = val;
        }
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Product Name: " +_productName);
            Console.WriteLine("Product ID: " +_productID);
            Console.WriteLine("Price: " +_price + "$");
        }
    }
}
