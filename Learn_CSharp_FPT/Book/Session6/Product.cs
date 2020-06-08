using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session6
{
    public class Product
    {
        static int productId;
        static double price;
        static Product()
        {
            productId = 10;
            price = 123.45;
        }
        public static void Dislpay()
        {
            Console.WriteLine("Product ID:" + productId);
            Console.WriteLine("Product price:" + price);
        }
    }
}
