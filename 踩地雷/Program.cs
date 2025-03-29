using System;

namespace 踩地雷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int size = int.Parse(data[0]);
            int landminesNum = int.Parse(data[1]);
            int[,] coordinate = new int[landminesNum, 2];

            for (int i = 0; i < landminesNum; i++)
            {
                string[] storage = Console.ReadLine().Split(' ');
                coordinate[i, 0] = int.Parse(storage[0]);
                coordinate[i, 1] = int.Parse(storage[1]);
            }

            Map m = new Map(size);
            string map = m.Creat();

            for (int i = 0; i < landminesNum; i++)
            {
                map = m.SetLandmines(map, coordinate[i, 0], coordinate[i, 1]);
            }
            Console.WriteLine(map);
        }
    }
}
