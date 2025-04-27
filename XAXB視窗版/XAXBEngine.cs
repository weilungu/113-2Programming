using System;
using System.Diagnostics.Metrics;

namespace S1131375XAXBGame
{
    internal class XAXBEngine // XAXB
    {
        // --Attribute--
        string luckyNum;
        int guessNums;

        // -- Constrctor --
        public XAXBEngine()
        {
            this.guessNums = 4;
            Random random = new Random();

            char[] nums = new char[guessNums];
            int index = 0;
            while (true)
            {
                char n = $"{random.Next(0, 9)}"[0]; // 隨機生成數字，轉成字串後，取第一個值
                if (Quantity(n, nums) > 0) // 若有重複，則重新生成隨機數字
                {
                    continue;
                }
                else // 否則把字元加到nums裡面
                {
                    nums[index] = n;
                    index++;
                }

                if (Quantity('\0', nums) == 0) // 如果3個值都不是char的預設值，就break掉
                {
                    break;
                }
            }
            foreach (char n in nums) // 連接起來
            {
                this.luckyNum += n;
            }
        }

        public int GetGuessNum { get => guessNums; }

        // -- static Method --
        static int Quantity(char element, char[] array) // 回傳重複的元素
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    result++;
                }
            }
            return result;
        }

        // -- Instance Methods --
        public bool IsLegal(string someNumber)
        {
            // 判斷 guessNumber 三位數字是否滿足：
            // (a) 長度剛好為 guessNum 的數量;
            // (b) 數字不重複
            // 滿足上述條件就回傳 true, 否則回傳 false

            bool result = true;
            if (someNumber.Length == this.guessNums) // 123
            {
                char[] storage = someNumber.ToCharArray();
                for (int i = 0; i < storage.Length; i++)
                {
                    result = !(Quantity(storage[i], storage) > 1);
                    if (!result)
                    {
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool isFilled(int counter)
        {
            return counter >= guessNums;
        }

        public bool SetLuckyNumber(string newLuckyNum)
        {
            bool result = IsLegal(newLuckyNum);
            if (result)
            {
                this.luckyNum = newLuckyNum;
            }
            return result;
        }
        public string GetLuckyNumber()
        {
            return this.luckyNum;
        }
        public string GetGuessResult(string guessNumber) // 位置對且相同:A, 相同但位置不對: B
        {
            char[] userInput = guessNumber.ToCharArray();
            char[] ComputerInput = this.luckyNum.ToCharArray();
            int A = 0, B = 0;
            string result = "";

            for (int i = 0; i < this.luckyNum.Length; i++) // 123 253 => 1A1B
            {
                if (userInput[i] == ComputerInput[i]) // 123 156 => 1A0B
                {
                    A++;
                }
                else if (Quantity(userInput[i], ComputerInput) == 1) // 123 256 => 0A1B
                {
                    B++;
                }
            }
            result = $"{A}A{B}B";

            return result;
        }
        public bool IsGameover(string guessNumber)
        {
            bool result = guessNumber == this.luckyNum;
            return result;
        }
    }
}