﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session9
{
    class Snippet5
    {
        private static string _department;
        private static string _universityName;
        public static string Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        public static string UniversityName
        {
            get
            {
                return _universityName;
            }
            set
            {
                _universityName = value;
            }
        }
    }
}
