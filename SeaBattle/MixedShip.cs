﻿using SeaBattle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class MixedShip : Ship, IShoot, IHeal
    {
        public MixedShip(int size) : base(size)
        {
        }

        public bool Heal()
        {
            throw new NotImplementedException();
        }

        public bool Shoot()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{base.ToString()} + MixedShip";
        }
    }
}
