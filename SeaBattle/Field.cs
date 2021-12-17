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
        private List<Ship> ships = new List<Ship>();
        Dictionary<Point, Ship> points = new Dictionary<Point, Ship>();

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
                
                if (points.ContainsKey(point))
                {
                    return points.Values.First((p)=>p.Equals(point));
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
                if (points.Count()==0)
                {

                    ships.Add(ship);
                    if (ship.Direction=="horizontal")
                    {
                        var x = point.X;
                        //for (int i = x; i <= ship.Size+x; i++)//может меньше равно
                        //{                            
                        //    points.Add(point, ship);//добавить point++ ибо поинт же увеличивается
                        //    point.X++;
                        //}
                        for (; point.X<= ship.Size + x; ++point.X)//может меньше равно
                        {
                            points.Add(point, ship);//добавить point++ ибо поинт же увеличивается
                            
                        }
                    }
                    else if (ship.Direction == "vertical")
                    {
                        var y = point.Y;
                        for (int i = y; i <= ship.Size + y; i++)//может меньше равно
                        {
                            points.Add(point, ship);
                            point.Y++;
                        }
                    }
                }
                else
                {
                    foreach (var item in points)
                    {
                        if (item.Key.X != point.X && item.Key.Y != point.Y)
                        {
                            ships.Add(ship);
                            if (ship.Direction == "horizontal")
                            {
                                var x = point.X;
                                for (int i = x; i <= ship.Size + x; i++)//может меньше равно
                                {
                                    points.Add(point, ship);
                                    point.X++;
                                }
                            }
                            else if (ship.Direction == "vertical")
                            {
                                var y = point.Y;
                                for (int i = y; i <= ship.Size + y; i++)//может меньше равно
                                {
                                    points.Add(point, ship);
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
            return points.OrderBy((pos)=> Math.Sqrt(Math.Pow(pos.Key.X, 2) + Math.Pow(pos.Key.Y, 2))).ToString();
        }
    }
}
