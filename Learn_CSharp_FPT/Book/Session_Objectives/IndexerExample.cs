﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session_Objectives
{
    class IndexerExample
    {
        public int[] intList = new int[10];
        public int this[int index]
        {
            get
            {
                return intList[index];
            }
            set
            {
                intList[index] = value;
            }
        }
    }
}
