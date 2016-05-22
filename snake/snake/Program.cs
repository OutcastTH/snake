using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.draw();

            Point p2 = new Point(4, 5, '#');
            p2.draw();

            HorizontalLine line = new HorizontalLine(1, 10, 8, '=');
            line.Drow();

            VerticalLine line1 = new VerticalLine(1, 10, 1, '|');
            line1.Drow1();

            Console.ReadLine();
        }
    }
}
