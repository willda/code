﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            point p1 = new point(1, 3, '*');
            p1.Draw();

            point p2 = new point(3, 4, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();

            Console.ReadLine();
        }
   
    }
}
