using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Quadrant
    {
        public Ship Ship { get; set; }
        public Point Point { get; set; }
        public int Qudrant { get; set; }
        public Quadrant(Ship ship, Point point, int qu)
        {
            this.Point = point;
            switch (qu)
            {
                case 1:
                    this.Point.X = point.X;
                    this.Point.Y = point.Y;
                    this.Qudrant = qu;
                    break;
                case 2:
                    this.Point.X = -point.X;
                    this.Point.Y = point.Y;
                    this.Qudrant = qu;
                    break;
                case 3:
                    this.Point.X = -point.X;
                    this.Point.Y = -point.Y;
                    this.Qudrant = qu;
                    break;
                case 4:
                    this.Point.X = point.X;
                    this.Point.Y = -point.Y;
                    this.Qudrant = qu;
                    break;
                default:
                    break;
            }
            this.Ship = ship;
            
        }

        public bool Equals(Ship x, Ship y)
        {
            if (x == y)
            {
                return true;
            }
            else return false;
        }


    }
}
