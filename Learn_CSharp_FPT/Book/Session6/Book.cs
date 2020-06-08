using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session6
{
    class Book
    {
        string bookName;
        public string Print()
        {
            return bookName;
        }
        public void Input(string bkName)
        {
            bookName = bkName;
        }
    }
}
