using System;

namespace 特伍拉汽車工廠
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            // 生成引擎物件
            Engine eng1 = new Engine(1600);
            Console.WriteLine("1600cc Engine: " + eng1.GetCost());
            Engine eng2 = new Engine(2000);
            Console.WriteLine("2000cc Engine: " + eng2.GetCost());
            // 生成空調物件
            Aircond airc1 = new Aircond("auto");
            Console.WriteLine("Auto Aircond: " + airc1.GetCost());
            Aircond airc2 = new Aircond("manual");
            Console.WriteLine("Manual Aircond: " + airc2.GetCost());
            // 生成音響物件
            Sound snd1 = new Sound();
            Console.WriteLine("Sound: " + snd1.GetCost());
        }
    }
}