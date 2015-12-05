﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Snake(point tail, int length, Direction direction)
        {
            plist = new List<point>();
            for (int i = 0; i<length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);

            }
        }
    }
}
