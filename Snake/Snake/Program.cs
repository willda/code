using System;
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

            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 23, '-');
            VerticaleLine leftLine = new VerticaleLine(0, 24, 0, '-');
            VerticaleLine rightLine = new VerticaleLine(0, 24, 78, '-');
            upLine.Draw();
            downLine.Draw();
            leftLine.Drow();
            rightLine.Drow();

            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
         }
   
    }
}
