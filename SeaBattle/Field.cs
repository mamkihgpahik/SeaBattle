using SeaBattle.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Field
    {
        private Help helper;
        private List<Ship> ships;
        public List<Point> points;
        private int Height { get; set; }
        private int Width { get; set; }
        public Field(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public Ship this[Point point]
        {
            get
            {
                var notEmpty = points.Find((p) => p.X == point.X && p.Y == point.Y && p.quadrant == point.quadrant);
                return notEmpty.ship;
            }
            set 
            {
                if (point._isEmpty)
                {
                    
                }
            }
        }
        public void AddShip(Ship ship, Point point)
        {
            if (points.Count==0)
            {
                ships.Add(ship);
                points.Add(point);
            }
            else
            {
                foreach (var item in points)
                {
                    if (item.X != point.X && item.Y != point.Y || point.X > Width || point.Y > Height)
                    {
                        ships.Add(ship);
                        points.Add(point);
                    }
                    else
                    {
                        Console.WriteLine("This point is already taken ");
                    }
                }             
            }
        }

    }
}
