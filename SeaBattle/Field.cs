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
        //Dictionary<Point, Ship> point1;
        List<Point> points;
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
                        var x = point.X;
                        //add item.ship = ship;
                        //points.add(point); все точки корабля от х до х+size
                        foreach (var item in points)
                        {
                            for (int i = x; i <= ship.Size + x; i++)
                            {
                                points.Add(point);
                                item.ship = ship;
                                point.X++;
                            }
                        }


                    }
                    else if (ship.Direction == "vertical")
                    {
                        var y = point.Y;
                        for (int i = y; i <= ship.Size + y; i++)//может меньше равно
                        {
                            points.Add(point);
                            point.Y++;
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
                                var x = point.X;
                                for (int i = x; i <= ship.Size + x; i++)//может меньше равно
                                {
                                    points.Add(point);
                                    point.X++;
                                }
                            }
                            else if (ship.Direction == "vertical")
                            {
                                var y = point.Y;
                                for (int i = y; i <= ship.Size + y; i++)//может меньше равно
                                {
                                    points.Add(point);
                                    point.Y++;
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
            return points.OrderBy((pos)=> Math.Sqrt(Math.Pow(pos.X, 2) + Math.Pow(pos.Y, 2))).ToString();
        }
    }
}
