using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Write
{


     class Product : ITest
    {
        string productName;
        int productID;
        float price;

        public Product()
        {
            //notthing
        } 

        //public Product(string productName, int productID, float price)
        //{
        //    this.productName = productName;
        //    this.productID = productID;
        //    this.price = price;
        //}

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if(price < 0) 
                { price = 0; }
                else { price = value; }
            }
        }

        //public double TinhTong(int Num1, int Num2);

        public double TinhTong(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }

        public void Test()
        {
            //TinhTong(1, 2, 3);
        }

        public void Test_Mobile()
        {
            Console.WriteLine("Tesst thanh cong tren DT");
        }

        public void Test_Deskop()
        {
            Console.WriteLine("Tesst thanh cong tren May Tinh");
        }
    }
}
