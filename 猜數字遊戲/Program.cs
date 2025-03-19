using System;

namespace S1131375XAXBGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerInput;

            XAXBKernel kernel = new XAXBKernel();
            kernel.SetLuckyNumber(Console.ReadLine()); // 設定幸運數字
            Console.WriteLine($"Lucky Number: {kernel.GetLuckyNumber()}");
            do
            {
                string guessResult;

                // 過濾掉不合法的輸入，直到該輸入合法為止
                bool illegal;
                do
                {
                    playerInput = Console.ReadLine();
                    illegal = !XAXBKernel.IsLegal(playerInput);

                    if(playerInput == "")
                    {
                        Console.WriteLine("");
                    }
                    else if (illegal)
                    {
                        Console.WriteLine($"{playerInput}: illegal");
                    }

                } while (illegal);

                // 進行比對
                guessResult = kernel.GetGuessResult(playerInput);
                Console.WriteLine($"{playerInput}: {guessResult}");

            } while (!kernel.IsGameover(playerInput)); // 遊戲結束代表玩家贏了

            Console.WriteLine("You rock!");
        }
    }
}