﻿
using bt2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Home a = new Lion(250, "Lion");
            a.Show();
            a = new Tiger(200, "Tiger");
            a.Show();
        }
    }
}