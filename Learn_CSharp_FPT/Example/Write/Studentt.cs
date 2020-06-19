using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Example.Write
{
    class Studentt
    {
        private int studentId;
        private string name;
        private int gpa;

        public int StudentID
        {
            get
            {
                return studentId;
            }
       
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }
        }

        public void Display()
        {
            Console.WriteLine(this.studentId + " " + this.name + " " + this.gpa);
        }
    }
}
