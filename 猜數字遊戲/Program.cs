using System;

namespace S1131375XAXBGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XAXBKernel xaxb = new XAXBKernel();
            xaxb.SetLuckyNumber("123");

            Console.WriteLine("{0} is legal? {1}", "1234", XAXBKernel.IsLegal("1234"));
            Console.WriteLine("{0} is legal? {1}", "123", XAXBKernel.IsLegal("123"));
            Console.WriteLine("{0}: {1}", "566", XAXBKernel.IsLegal("566") ? "legal" : "illegal");

            Console.WriteLine("{0}: {1}", "787", XAXBKernel.IsLegal("787") ? "legal" : "illegal");
            Console.WriteLine("{0}: {1}", "770", XAXBKernel.IsLegal("770") ? "legal" : "illegal");
            Console.WriteLine("{0}: {1}", "079", XAXBKernel.IsLegal("079") ? "legal" : "illegal");

            string result1 = xaxb.GetGuessResult("124");
            Console.WriteLine("{0} {1}: {2}", xaxb.GetLuckyNumber(), "124", result1);

            string result2 = xaxb.GetGuessResult("123");
            Console.WriteLine("{0} {1}: {2}", xaxb.GetLuckyNumber(), "123", result2);
            Console.WriteLine("{0} gameover: {1}", "125", xaxb.IsGameOver("125"));
            Console.WriteLine("{0} gameover: {1}", "123", xaxb.IsGameOver("123"));
        }
    }
}