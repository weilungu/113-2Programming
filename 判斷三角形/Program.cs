using System;

namespace S1131375XAXBGame
{
    internal class Program
    {
        static int FindMax(int[] datas)
        {
            int max = datas[0];

            foreach (int i in datas)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        static bool isTriangle(int[] datas)
        {
            int max = FindMax(datas);
            int a, b, c;
            a = datas[0];
            b = datas[1];
            c = datas[2];

            bool result = a == max && (b + c) > a
                      || b == max && (c + a) > b
                      || c == max && (a + b) > c;

            return result;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] datas = new int[input.Length];

            for (int i = 0; i < datas.Length; i++) // 把 string 的 array 轉成 int 的
            {
                datas[i] = int.Parse(input[i]);
            }

            Console.WriteLine(isTriangle(datas) ? "Yes" : "No");
            // 若是三角形，則輸出 Yes，否則輸出 No
        }
    }
}