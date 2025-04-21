namespace s1131375_XAXB_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XAXB_Engine XAXB = new XAXB_Engine();
            //System.Console.WriteLine(XAXB.GetLuckyNumber());
            //string result1 = xaxb.GetResult("234");
            //string result2 = xaxb.GetResult("334");
            //string result3 = xaxb.GetResult("0123456789");

            //Console.WriteLine($"{result1}");
            //Console.WriteLine($"{result2}");
            //Console.WriteLine($"{result3}");

            int counter = 0;
            while (true)
            {
                // 1、input guess + count
                Console.Write("請輸入: ");
                string? playerGuess = Console.ReadLine();

                // is ligal
                if (!XAXB.IsLegal(playerGuess))
                {
                    Console.WriteLine("請輸入三個不重複的數字");
                    continue;
                }

                counter++;

                // 2、print resuklt
                string result = XAXB.GetResult(playerGuess);
                Console.WriteLine($"[{counter}] {playerGuess} : {result}");

                // isGuess?
                if(result == "3A0B")
                {
                    Console.WriteLine($"恭喜你猜中了，幸運號碼為: {XAXB.GetLuckyNumber()}");
                    break;
                }

            }
        }
    }
}
