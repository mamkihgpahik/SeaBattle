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
        Dictionary<Point, Ship> ps; 
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
                if (points.Count() > 0)
                {
                    var notEmpty = points.Find((p) => p.X == point.X && p.Y == point.Y && p.quadrant == point.quadrant);
                    return notEmpty.ship;
                }
                else
                {
                    throw new ArgumentNullException("List is empty");
                }

            }
        }
        public void AddShip(Ship ship, Point point)
        {
           
            if (point.X > Width && point.Y > Height)
            {
                throw new ArgumentOutOfRangeException("You went out of the playing field ");
            }
            else
            {
                if (points.Count == 0 )
                {
                    ships.Add(ship);
                    if (ship.Direction=="horizontal")
                    {
                        for (int i = point.X; i < ship.Size+point.X; i++)//может меньше равно
                        {
                            points.Add(point);
                        }
                    }
                    else if (ship.Direction == "vertical")
                    {
                        for (int i = point.Y; i < ship.Size + point.Y; i++)//может меньше равно
                        {
                            points.Add(point);
                        }
                    }
                }
                else
                {
                    foreach (var item in points)
                    {
                        if (item.X != point.X && item.Y != point.Y)
                        {
                            ships.Add(ship);
                            if (ship.Direction == "horizontal")
                            {
                                for (int i = point.X; i < ship.Size + point.X; i++)//может меньше равно
                                {
                                    points.Add(point);
                                }
                            }
                            else if (ship.Direction == "vertical")
                            {
                                for (int i = point.Y; i < ship.Size + point.Y; i++)//может меньше равно
                                {
                                    points.Add(point);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("This point is already taken ");
                        }
                    }

                }
            }
        }
        public override string ToString()
        {
            return ;
        }
        //public override string ToString()
        //{
        //    return ships.OrderBy((sh) => Math.Sqrt(Math.Pow(sh.pointStart.X, 2) + Math.Pow(sh.pointStart.Y, 2))).ToString();
        //}
    }
}
