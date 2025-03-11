using System;

namespace S1131375XAXBGame
{
    class PerfectNum
    {
        public static void Append(ref int[] array, int value) // 類似 python 的 append
        {
            Array.Resize(ref array, array.Length + 1); // 調整 Array 大小 +1
            array[array.Length - 1] = value; // 加上值
        }
        public static int Sum(params int[] nums) // 算出 int array 的加總
        {
            int sum = 0;
            foreach (int n in nums)
            {
                sum += n;
            }
            return sum;

            //if(nums.Length == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return nums[0] + Sum(nums[1..]);
            //}
        }
        public static int[] getFactorArray(int num) // 判斷參數的所有因數
        {
            int[] factors = new int[num];
            for (int i = 0, j = 1; j < num; j++) // i: 第幾個索引值, j: 因數
            {
                if (num % j == 0)
                {
                    factors[i] = j;
                    i++;
                }
            }

            return factors;
        }
        public static bool isPerfectNum(int num) // 判斷是否為完美數
        {
            int factorSum = Sum(getFactorArray(num)); // 所有因數加總

            return factorSum == num;
        }
        public static int[] getAllPerfectNum(int num1, int num2) // 找出範圍中所有的完美數
        {
            int[] datas = { num1, num2 };
            int[] result = new int[0];

            if (num1 < num2) // 1, 50
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (isPerfectNum(i))
                    {
                        Append(ref result, i);
                    }
                }
            }
            else // num1 >= num2
            {
                for (int i = num2; i <= num1; i++)
                {
                    if (isPerfectNum(i))
                    {
                        Append(ref result, i);
                    }
                }
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- input & typeCasting ---

            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            // --- 格式 & 輸出 ---

            string result = "";
            int[] perfectNums = PerfectNum.getAllPerfectNum(nums[0], nums[1]);

            if (perfectNums.Length > 0)
            {
                foreach (int num in perfectNums)
                {
                    result += $"{num},";
                }
                result = result.Remove(result.Length - 1, 1);
            }
            else
            {
                result = "NONE";
            }

            result = $"Perfect numbers between {input[0]} to {input[1]}: {result}";
            Console.WriteLine(result);

            // --- 前 ---

            //int input = int.Parse(Console.ReadLine());

            //Console.WriteLine(PerfectNum.isPerfectNum(input)
            //    ? $"{input}: perfect number"
            //    : $"{input}: normal number");

            //// 判斷 input 所有因數加總，是否 = input
            //// 若是，則輸出 perfect number
            //// 否則輸出 normal number
        }
    }
}