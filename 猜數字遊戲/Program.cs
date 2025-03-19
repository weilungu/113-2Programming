using System;

namespace S1131375XAXBGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 生成猜數字遊戲核心模組
            XAXBKernel xaxb = new XAXBKernel();
            // 2. 手動設定幸運號碼
            xaxb.SetLuckyNumber("1234");
            // 3-1. 驗證相關模組是否設計正確？
            Console.WriteLine("{0} is legal? {1}", "1234", XAXBKernel.IsLegal("1234"));
            Console.WriteLine("{0} is legal? {1}", "123", XAXBKernel.IsLegal("123"));
            Console.WriteLine("{0}: {1}", "5665", XAXBKernel.IsLegal("5665") ? "legal" : "illegal");
            Console.WriteLine("{0}: {1}", "7878", XAXBKernel.IsLegal("7878") ? "legal" : "illegal");
            Console.WriteLine("{0}: {1}", "7897", XAXBKernel.IsLegal("7897") ? "legal" : "illegal");
            Console.WriteLine("{0}: {1}", "0789", XAXBKernel.IsLegal("0789") ? "legal" : "illegal");
            // 3-2. 驗證相關模組是否設計正確？
            String result1 = xaxb.GetGuessResult("1245");
            Console.WriteLine("{0} {1}: {2}", xaxb.GetLuckyNumber(), "1245", result1);
            String result2 = xaxb.GetGuessResult("1234");
            Console.WriteLine("{0} {1}: {2}", xaxb.GetLuckyNumber(), "1234", result2);
            // 3-3. 驗證相關模組是否設計正確？
            Console.WriteLine("{0} gameover: {1}", "1254", xaxb.IsGameover("1254"));
            Console.WriteLine("{0} gameover: {1}", "1234", xaxb.IsGameover("1234"));
        }
    }
}