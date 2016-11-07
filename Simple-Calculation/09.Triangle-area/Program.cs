﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;

            Console.WriteLine("Triangle area = {0}", Math.Round(area,10));
            Console.WriteLine("Triangle area = {0:0.##}", area);
            Console.WriteLine("Triangle area = {0:0.00}", area);
        }
    }
}
