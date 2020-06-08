using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session_Objectives
{
    class ListBox : Window
    {
        public ListBox(int top, int left, string contents):base(top, left)
        {
            listBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}",listBoxContents);
        }
        private string listBoxContents;
    }
}
