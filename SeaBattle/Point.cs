using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool _isEmpty { get; set; } = false;
        public int quadrant { get; set; }
        public Point(int x, int y, int qu)
        {
            this.X = x;
            this.Y = y;
            this.quadrant = qu;
        }
    }
}
