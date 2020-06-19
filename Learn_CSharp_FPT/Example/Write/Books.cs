using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Write
{
    class Books
    {
        string bookName;
        long bookID;
        public Books(string bookName, long bookID)
        {
            this.bookName = bookName;
            this.bookID = bookID;
        }
         public string BookName
        {
            get
            {
                return bookName;
            }
        }
        public long BookID
        {
            set
            {
                bookID = value;
            }
            get
            {
                return bookID;
            }
        }
        public void hienThi()
        {
            Console.WriteLine(this.bookName + " " + this.bookID);
        }
    }
}
