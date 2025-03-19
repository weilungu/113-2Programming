using System;

namespace 特伍拉汽車工廠
{
    public class TestMain
    {
        public class CarMain
        {
            public static void Main(String[] args)
            {
                BasicCar bc = new BasicCar(1600, "manual");
                Console.WriteLine("Basic car cost: " + bc.GetCost());
                Console.WriteLine("Basic car price: " + bc.GetPrice());

                LuxCar luxc = new LuxCar(2000, "auto");
                Console.WriteLine("Lux car cost: " + luxc.GetCost());
                Console.WriteLine("Lux car price: " + luxc.GetPrice());
            }
        }
    }
}