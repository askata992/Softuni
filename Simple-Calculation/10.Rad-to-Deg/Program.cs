﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rad_to_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double deg = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(deg));
        }
    }
}
