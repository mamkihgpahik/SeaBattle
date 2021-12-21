using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Field
    {
        private List<Ship> ships;
        private List<Quadrant> quadrants;
        private List<Point> points;
        private int Height { get; set; }
        private int Width { get; set; }
        public Field(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            ships = new List<Ship>();
            points = new List<Point>();
            quadrants = new List<Quadrant>();
        }

        public Ship this[Point point, int quadrant]
        {
            get
            {
                if (quadrants.Count() > 0)
                {
                    var nemp = quadrants.Find((q) => Math.Abs(q.Point.X) == Math.Abs(point.X) && Math.Abs(q.Point.Y) == Math.Abs(point.Y) && q.Qudrant == quadrant);
                    return nemp.Ship;
                }
                else
                {
                    throw new ArgumentNullException("List is empty");
                }

            }
        }
        public void AddShip(Ship ship, Point point, int quadrant)
        {

            if (point.X > Width && point.Y > Height)
            {
                throw new ArgumentOutOfRangeException("You went out of the playing field ");
            }
            else
            {
                if (quadrants.Count == 0)
                {
                    ships.Add(ship);
                    if (ship.Direction == "horizontal")
                    {
                        var x = point.X;
                        for (int i = x; i < ship.Size + x; i++)
                        {
                            var point1 = new Point(i, point.Y);
                            points.Add(point1);
                            quadrants.Add(new Quadrant(ship, point1, quadrant));
                        }

                    }
                    else if (ship.Direction == "vertical")
                    {
                        var y = point.Y;
                        for (int i = y; i < ship.Size + y; i++)
                        {
                            var point1 = new Point(point.X, y);
                            points.Add(point1);
                            quadrants.Add(new Quadrant(ship, point1, quadrant));
                        }
                    }
                }
                else
                {
                    if (!points.Contains(point))
                    {
                        ships.Add(ship);
                        if (ship.Direction == "horizontal")
                        {
                            var x = point.X;
                            for (int i = x; i < ship.Size + x; i++)
                            {
                                var point1 = new Point(x, point.Y);
                                points.Add(point1);
                                quadrants.Add(new Quadrant(ship, point1, quadrant));
                            }
                        }
                        else if (ship.Direction == "vertical")
                        {
                            var y = point.Y;
                            for (int i = y; i < ship.Size + y; i++)
                            {
                                var point1 = new Point(point.X, y);
                                points.Add(point1);
                                quadrants.Add(new Quadrant(ship, point1, quadrant));
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
        public override string ToString()
        {
            var qua = quadrants.OrderBy((qua) => Math.Sqrt(Math.Pow(qua.Point.X, 2) + Math.Pow(qua.Point.Y, 2)));
            string str = "";
            foreach (var item in qua)
            {
                 str += $" {item.Ship.ToString()}\n";
            }
            return str;
        }
    }
}
