using System;

namespace 特伍拉汽車工廠
{
    public class TestMain
    {
        public class CarMain
        {
            public static void Main(string[] args)
            {
                Warehouse wh = new Warehouse(100);

                BasicCar c1 = new BasicCar(1600, "manual");
                LuxCar c2 = new SuperLuxCar(2000, "auto");
                SuperLuxCar c3 = new SuperLuxCar(2000, "auto");

                Car[] cars = new Car[] {c1, c2, c3};

                wh.AddCar(cars[0]);
                wh.AddCar(cars[1]);
                wh.AddCar(cars[2]);

                int cp, tc, tp;
                cp = wh.GetCapacity();
                //tc = wh.GetTotalCost();
                //tp = wh.GetTotalPrice();
                int[] test = new int[1] { cp };

                for(int i = 0; i < test.Length; i++)
                {
                    Console.WriteLine(test[i]);
                }
            }
        }
    }
}