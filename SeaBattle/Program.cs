using System;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(10, 10);
            Ship ship;
            Point point = new Point(1, 3);
            Point point1 = new Point(3, 4);
            WarShip warShip = new WarShip(4, 40, 2, "vertical");
            WarShip warShip1 = new WarShip(4, 40, 2, "vertical");
            SupportShip suppShip = new SupportShip(3, 45, 2, "vertical");
            MixedShip mixedShip = new MixedShip(2, 20, 3, "horizontal");
            field.AddShip(mixedShip, point, 1);
            field.AddShip(suppShip, point1, 2);
            Console.WriteLine(field[point, 1].ToString());
            Console.WriteLine(field[point1, 2].ToString());
            if (warShip == warShip1)
            {
                Console.WriteLine("Ships are equil");
            }
            if (warShip != suppShip)
            {
                Console.WriteLine("Ships are not equil");
            }

            Console.WriteLine(field.ToString()); 
        }
    }
}
