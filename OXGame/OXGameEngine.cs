using System;

namespace OXGame
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

        // 設定某一位置的玩家標記
        public void SetMarker(int x, int y, char player)
        {
            if (IsValidMove(x, y))
            {
                board[x, y] = player;
                //
                counter++;
            }
            else
            {
                throw new InvalidOperationException("Invalid move.");
            }
        }

        // 重置遊戲
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
        }

        // 判斷是否有贏家
        public char IsWinner()
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

        //
        public Boolean IsTie()
        {
            return counter == 9;
        }
        // 取得指定位置的標記
        public char GetMarker(int x, int y)
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

        // 檢查指定位置是否為空
        public bool IsEmpty(int x, int y)
        {
            return board[x, y] == ' ';
        }

        // 檢查指定位置是否有效
        public bool IsValidMove(int x, int y)
        {
            return x >= 0 && x < 3 && y >= 0 && y < 3 && IsEmpty(x, y);
        }
    }
}
