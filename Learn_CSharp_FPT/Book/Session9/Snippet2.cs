using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    class Snippet2
    {
        string _bookName;
        long _bookID;
        public Snippet2(string name, int value)
        {
            _bookName = name;
            _bookID = value;
        }
        public string BookName
        {
            get
            {
                return _bookName;
            }
        }
        public long BookID
        {
            get
            {
                return _bookID;
            }
        }
    }
}
