using System;

namespace OXGame文字版
{
    internal class OXGameEngine
    {
        private char[,] board;
        private int counter = 0;
        public OXGameEngine()
        {
            // 初始化棋盤，3x3，預設為空格
            board = new char[3, 3]
            {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' }
            };
            //
            counter = 0;
        }

        // === 渲染畫面 ===

        string GridFormat(int mode=0, int nums=7, int markerIndex=0) // 設定棋盤格式
        {
            // 當 mode 為 0 時，印出 nums 個 "="
            // 當 mode 為 1 時，印出 nums 個 "|" or "board[markerIndex, j]"
            char element = '\0';
            string result = null;
            if (mode == 0)
            {
                element = '='; // "=" 代替 "_"，因為看起來比較美觀，至少我是這麼覺得的
                for (int i = 0; i < nums; i++)
                {
                    result += element;
                }
            }
            else if (mode == 1)
            {
                element = '|';
                for (int i=0, j=0; i < nums; i++)
                {
                    bool isEven = (i % 2 == 0);

                    result += isEven ? element : board[markerIndex, j];
                    if(i < nums-3 && !isEven)
                    {
                        j++;
                    }
                }
            }

            return result;
        }
        public void DrawBoard(int nums=7) // 把棋盤用格式畫出來
        { // 不管是 橫線 or 直線+棋盤的值 ，一行的長度加起來都為 7
            for (int i = 0, index = 0; i < nums; i++)
            {
                bool isEven = (i % 2) == 0;
                if (isEven)
                {
                    Console.WriteLine(GridFormat(mode: 0, nums)); // 橫線
                }
                else
                {
                    Console.WriteLine(GridFormat(mode: 1, nums, index)); // 直線 + 棋盤的值
                    index++;
                }
            }
            Console.WriteLine(); // 空一行比較好看
        }

        // === 遊戲更新 ===

        public char ConvertPlayer(int ranking, params char[] players) // 回傳第 ranking 順位的 players
        {
            if(ranking >= players.Length)
            {
                ranking = ranking % players.Length;
            }
            else if(ranking < 0)
            {
                ranking = 0;
            }

            return players[ranking];
        }
        public void SetMarker(int x, int y, char player) // 設定某一位置的玩家標記
        {
            if (IsValidMove(x, y)) // 若為有效移動，則執行程式碼
            {
                board[x, y] = player;
                //
                counter++;
            }
            else // 否則提醒玩家
            {
                //throw new InvalidOperationException("Invalid move.");

                string hint = "該位置已經有子，或不再棋盤範圍內，請重新輸入";
                Console.WriteLine(hint);
            }
        } 
        public void ResetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';  // 0x20
                }
            }
            //
            counter = 0;
        } // 重置遊戲

        // === 是否為贏 or 平手 ===

        public char IsWinner() // 判斷是否有贏家
        {
            // 檢查每一列
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
            }

            // 檢查每一行
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            // 檢查兩條對角線
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];

            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            // 如果沒有贏家，回傳空白字符
            return ' ';
        }
        public bool IsTie()
        {
            return counter == 9;
        } // 是否平手

        //  === Debug ===

        public char GetMarker(int x, int y) // 取得指定位置的標記
        {
            if (x >= 0 && x < 3 && y >= 0 && y < 3)
            {
                return board[x, y];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Coordinates must be between 0 and 2.");
            }
        }
        public bool IsEmpty(int x, int y) // 檢查指定位置是否為空
        {
            return board[x, y] == ' ';
        }
        public bool IsValidMove(int x, int y) // 檢查指定位置是否有效
        {
            return x >= 0 && x < 3 && y >= 0 && y < 3 && IsEmpty(x, y);
        }
    }
}
