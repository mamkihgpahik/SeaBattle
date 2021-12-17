using System;
using System.Linq;
using SeaBattle.Interfaces;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(10, 10);
            Ship ship;
            WarShip warShip = new WarShip(4, 40, 2, "vertical");
            WarShip warShip1 = new WarShip(4, 40, 2, "vertical");
            SupportShip suppShip = new SupportShip(3, 45, 2, "vertical");
            MixedShip mixedShip = new MixedShip(3, 20, 3, "horizontal");
            field.AddShip(mixedShip, new Point(2, 3, 1));
            field.AddShip(suppShip, new Point(3, 4, 2));
            if (warShip == warShip1)
            {
                Console.WriteLine("Ships are equil");
            }
            if (warShip != suppShip)
            {
                Console.WriteLine("Ships are not equil");
            }
            Console.WriteLine(field[new Point(1, 3, 1)].ToString());
        }
    }
}
