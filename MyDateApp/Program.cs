using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace s1131375Ex0224_MyDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate d1 = new MyDate(2024, 3, 11);
            //Console.WriteLine(d1); // --> 主動呼叫 ToString()
            //
            MyDateTime dt1 = new MyDateTime(2024, 3, 15, 12, 30, 0);
            string dt1Str = dt1.GetDateTime();
            Console.WriteLine(dt1Str);
        }
    }
}
