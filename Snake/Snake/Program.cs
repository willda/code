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

            List<int> numList = new List<int>();
            numList.Add( 0 );
            numList.Add( 1 );
            numList.Add( 2 );

            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];

            foreach( int i in numList)
            {
                Console.WriteLine(1);
            };

            numList.RemoveAt(0);

            List<point> pList = new List<point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
