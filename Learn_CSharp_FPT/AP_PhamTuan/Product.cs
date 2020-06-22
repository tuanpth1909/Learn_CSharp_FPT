using System;
using System.Collections.Generic;
using System.Text;

namespace AP_PhamTuan
{
        abstract class Product
        {
            //tao truong
            int id;
            string name;
            public double price;
            string producer;

            //Tao Constructor
            public Product(int id, string name, double price, string producer)
            {
                this.id = id;
                this.name = name;
                this.price = price;
                this.producer = producer;
            }
            public int Id
            {
                get; set;
            }
            public string Name
            {
                get; set;
            }
            public int Price
            {
                get; set;
            }
            public int Producer
            {
                get; set;
            }

            //
            public abstract double computeTax();
        }
    }
