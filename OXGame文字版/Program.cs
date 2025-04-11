using System;

namespace OXGame文字版
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OXGameEngine engine = new OXGameEngine();

            bool gameAgain;
            do
            {
                // === 初始化遊戲 ===
                char winner;
                bool isTie;
                engine.ResetGame();

                // === GameLoop ===
                for (int ranking = 0; true; ranking++) // 用 for 迴圈創建一個無窮迴圈，若有贏家或平手，則跳出迴圈
                {
                    // --- 取得輸入 ---

                    char player = engine.ConvertPlayer(ranking, 'X', 'O');
                    int[] coord = GetCoordinate($"玩家{player} 請輸入下子位置[0~2] (列 行): "); // 提示 & 取得 (x, y) 位置

                    // --- 遊戲更新 ---

                    int x = coord[0], y = coord[1];
                    if (!engine.IsValidMove(x, y)) // 錯誤後，確保不會讓玩家的子變成下一位的
                        ranking--;

                    // --- 畫面顯示 ---

                    engine.SetMarker(x, y, player);
                    engine.DrawBoard(); // 渲染畫面

                    // --- 檢查是否有人贏 or 平手 ---

                    winner = engine.IsWinner();
                    isTie = engine.IsTie();

                    if (winner != ' ' || engine.IsTie()) break;
                } // 跳出迴圈代表有人贏 or 平手

                Console.WriteLine(isTie ? "此局平手" : $"贏家為{winner}"); // 若非平手，必有人贏

                // === 再來一次 ===
                Console.Write("是否再來一局 (Y/N): ");
                gameAgain = Console.ReadLine().ToUpper() == "Y";

            } while(gameAgain);
        }
        static int[] GetCoordinate(string input)
        {
            Console.Write(input);
            string[] data = Console.ReadLine().Split(' ');
            int[] reslut = new int[data.Length];

            for(int i=0; i<data.Length; i++)
            {
                reslut[i] = int.Parse(data[i]);
            }

            return reslut;
        }
    }
}