using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticaleLine
    {
        List<point> plist;

        public VerticaleLine(int x, int yUp, int yDown, char sym)
        {
            plist = new List<point>();
            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);

            }

        }
        public void Draw()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}