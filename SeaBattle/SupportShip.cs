using SeaBattle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class SupportShip : Ship, IHeal
    {
        public SupportShip(int size) : base(size)
        {
        }

        public bool Heal()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{base.ToString()} + SuppotrShip";
        }
    }
}
