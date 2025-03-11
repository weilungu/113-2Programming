using System;

namespace 特伍拉汽車工廠
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicCar bc1 = new BasicCar(1600, "manual");
            Console.WriteLine("Basic car1 cost: " + bc1.getCost());
            Console.WriteLine("Basic car1 price: " + bc1.getPrice());

            BasicCar bc2 = new BasicCar(2000, "auto");
            Console.WriteLine("Basic car2 cost: " + bc2.getCost());
            Console.WriteLine("Basic car2 price: " + bc2.getPrice());
        }
    }
}