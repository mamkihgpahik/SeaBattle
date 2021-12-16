using SeaBattle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public abstract class Ship : IShip
    {
        public int Speed { get; set; }
        public string Direction { get; set; }
        private int Size { get; set; }
        public int Radius { get; set; }
        public Ship(int size, int speed, int radius, string direction)
        {
            this.Size = size;
            this.Radius = radius;
            this.Speed = speed;
            this.Direction = direction;
        }
        public bool Move()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Size = {Size}, Speed = {Speed}, Radius = {Radius}, Direction = {Direction}";
        }
        public static bool operator ==(Ship ship1, Ship ship2)
        {
            if (ship1.GetType() == ship2.GetType() && ship1.Size == ship2.Size && ship1.Speed == ship2.Speed)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Ship ship1, Ship ship2)
        {
            if (ship1.GetType() != ship2.GetType() || ship1.Size != ship2.Size || ship1.Speed != ship2.Speed)
            {
                return true;
            }
            else return false;
        }
    }
}
