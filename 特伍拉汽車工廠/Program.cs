using System;

namespace 特伍拉汽車工廠
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            SuperLuxCar car1 = new SuperLuxCar(2000, "auto");
            Console.WriteLine("Car1 cost: " + car1.GetCost());
            Console.WriteLine("Car1 price: " + car1.GetPrice());
            LuxCar car2 = new LuxCar(2000, "auto");
            Console.WriteLine("Car2 cost: " + car2.GetCost());
            Console.WriteLine("Car2 price: " + car2.GetPrice());
            Console.WriteLine("Is Car1 more expensive than Car2: " + car1.IsExpensive(car2));
        }
    }
}