﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_FPT.Book.Session_Objectives
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start() 
        {
            System.Console.WriteLine(model + "started");
                }
        public void Stop()
        {
            System.Console.WriteLine(model + "stopped");
        }
    }
}
