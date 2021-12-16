using SeaBattle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class WarShip : Ship, IShoot
    {
        public WarShip(int size) : base(size)
        {
        }

        public bool Shoot()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{base.ToString()} + WarShip";
        }
    }
}
