using System;

namespace Test_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Villager vill = new Villager();
            Monster mon = new Monster();


            Console.WriteLine($"村民被攻擊前的血量: {vill.HP}");

            mon.Attack( vill );
            

            Console.WriteLine($"村民被攻擊後的血量: {vill.HP}");

        }
    }
}