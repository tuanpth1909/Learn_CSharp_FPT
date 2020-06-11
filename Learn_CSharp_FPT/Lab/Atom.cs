using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Lab
{
    class Atom
    {

        //Tao thuoc tinh
        public int number;
        public string symbol;
        public string fullname;
        public int weight;

        //Tao constructor
        public Atom(int number, string symbol, string fullnam, int weight)
        {
            this.number = number;
            this.symbol = symbol;
            this.fullname = fullname;
            this.weight = weight;
        }

        //Tao cac phuong thuc
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = number;
            }
        }

        public string Symbol
        {
            get
            {
                return Symbol;
            }
            set
            {
                this.symbol = symbol;
            }
        }

        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                this.fullname = fullname;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = weight;
            }
        } 
    }
}
