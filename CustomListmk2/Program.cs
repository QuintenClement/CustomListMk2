﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListmk2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list1 = new MyList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);
            list1.Add(4);
            list1.Add(6);
            list1.Add(8);
            list1.Remove(5);
        }
    }
}
