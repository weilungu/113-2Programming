using System;

namespace S1131375XAXBGame
{
    class LeapYear
    {
        public static string[] getLeapYears(int year1, int year2) // 取得所有區間所有閏年 (string Array)
        {
            string[] result = new string[((year2 - year1) / 4) + 1];
            for (int i = 0; year1 <= year2; year1++)
            {
                bool isLeapYear = (year1 % 4 == 0 && year1 % 100 != 0) ||
                                   year1 % 400 == 0 ||
                                   year1 % 1000 == 0; // 找出閏年
                if (isLeapYear)
                {
                    result[i] = $"{year1}";
                    i++;
                }
            }

            return result;
        }
    }
    internal class Progrsm
    {
        static void Main(string[] args)
        {
            // --- 使用者輸入 & typeCasting --- ok

            string[] input = Console.ReadLine().Split(' ');
            int[] datas = new int[input.Length];
            string result = $"NONE";
            int total = 0;

            for (int i = 0; i < input.Length; i++) // 將輸入的 string Array 轉成 int Array
            {
                datas[i] = int.Parse(input[i]);
            }


            // --- 判斷格式是否正確 & 找出 result --- ok

            bool isWrongFormat = datas[0] > datas[1];
            foreach (int d in datas) // 判斷格式是否錯誤
            {
                if (isWrongFormat)
                {
                    break;
                }
                isWrongFormat = d <= 0;
            }

            if (isWrongFormat)
            {
                result = "Wrong Input";
            }
            else if (datas[1] - datas[0] >= 4)
            {
                string[] getLY = LeapYear.getLeapYears(datas[0], datas[1]); // 取得閏年
                foreach (string ly in getLY)
                {
                    if (ly != null)
                    {
                        total += 1;
                    }
                }

                result = "";
                foreach (string ly in getLY)
                {
                    if (ly != null)
                    {
                        result += $"{ly},";
                    }
                }
                result = result.Remove(result.Length - 1, 1); // 把最後的 "," 移除
            }

            // --- 輸出格式 --- ok

            if (isWrongFormat)
            {
                result = $"{input[0]}~{input[1]}: {result}";
            }
            else
            {
                result = $"{input[0]}~{input[1]}: {result}\n" +
                         $"Total: {total} leap years.";
            }

            Console.WriteLine(result);

        }
    }
}