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
        public Ship ship { get; set; }
        public int quadrant { get; set; }
        public Point(int x, int y, int qu)
        {
            switch (qu)
            {
                case 1:
                    this.X = x;
                    this.Y = y;
                    this.quadrant = qu;
                    break;
                case 2:
                    this.X = -x;
                    this.Y = y;
                    this.quadrant = qu;
                    break;
                case 3:
                    this.X = -x;
                    this.Y = -y;
                    this.quadrant = qu;
                    break;
                case 4:
                    this.X = x;
                    this.Y = -y;
                    this.quadrant = qu;
                    break;
                default:
                    break;
            }

        }
    }
}
