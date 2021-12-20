using System;
using System.Collections;
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
        //public int quadrant { get; set; }
        //public Ship ship { get; set; }
        //public Point(int x, int y, int qu)
        //{
        //    switch (qu)
        //    {
        //        case 1:
        //            this.X = x;
        //            this.Y = y;
        //            this.quadrant = qu;
        //            break;
        //        case 2:
        //            this.X = -x;
        //            this.Y = y;
        //            this.quadrant = qu;
        //            break;
        //        case 3:
        //            this.X = -x;
        //            this.Y = -y;
        //            this.quadrant = qu;
        //            break;
        //        case 4:
        //            this.X = x;
        //            this.Y = -y;
        //            this.quadrant = qu;
        //            break;
        //        default:
        //            break;
        //    }

        //}
        //public Point(Point point)
        //{
        //    switch (point.quadrant)
        //    {
        //        case 1:
        //            this.X = point.X;
        //            this.Y = point.Y;
        //            this.quadrant = point.quadrant;
        //            break;
        //        case 2:
        //            this.X = point.X;
        //            this.Y = point.Y;
        //            this.quadrant = point.quadrant;
        //            break;
        //        case 3:
        //            this.X = point.X;
        //            this.Y = point.Y;
        //            this.quadrant = point.quadrant;
        //            break;
        //        case 4:
        //            this.X = point.X;
        //            this.Y = point.Y;
        //            this.quadrant = point.quadrant;
        //            break;
        //        default:
        //            break;
        //    }
        //}
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
