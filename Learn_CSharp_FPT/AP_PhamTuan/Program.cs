using System;

namespace AP_PhamTuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] myProduct =
               {
                new Book(1, "De men phieu luu ky", 15000, "Kim Dong"),
                new Book(2, "Doraemon", 10000, "Kim Dong"),
                new Book(3, "Chu Van An", 5000, "Kim Dong"),
                new MobilePhone(11, "Iphone5", 12, "Apple"),
                new MobilePhone(22, "Iphone6", 120, "Apple"),
                new MobilePhone(33, "Iphone7", 12000, "Apple")
            };

            double sumTax = 0;
            foreach (var item in myProduct)
            {
                sumTax = item.computeTax();
            }
            Console.WriteLine("Tax is:" + sumTax);
        }
    }
}
