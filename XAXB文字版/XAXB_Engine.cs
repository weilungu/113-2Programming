using System;

namespace s1131375_XAXB_Game
{
    internal class XAXB_Engine
    {
        string luckynum;
        public XAXB_Engine()
        {
            Random random = new Random();
            int[] tem = new int[3];
            tem[0] = random.Next(0, 9);
            tem[1] = random.Next(0, 9);
            tem[2] = random.Next(0, 9);
            while (tem[0] == tem[1] || tem[1] == tem[2] || tem[0] == tem[2])
            {
                tem[1] = random.Next(0, 9);
                tem[2] = random.Next(0, 9);
            }
            luckynum = $"{tem[0]}{tem[1]}{tem[2]}";
        }
        public bool SetLuckyNumber(String newLuckyNum)
        {
            if (IsLegal(newLuckyNum))
            {
                this.luckynum = newLuckyNum;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetLuckyNumber()
        {
            return this.luckynum;
        }
        public Boolean IsLegal(String theNumber)
        {
            char[] tem = theNumber.ToCharArray();
            if (tem.Length == 3)
            {
                if (tem[0] != tem[1] ^ tem[1] != tem[2] ^ tem[0] != tem[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string GetResult(String userNumber)
        {
            char[] user = userNumber.ToCharArray();
            char[] ans = this.luckynum.ToCharArray();
            int a = 0;
            int b = 0;
            for (int i = 0; i < user.Length; i++)
            {
                for (int j = 0; j < ans.Length; j++)
                {
                    if (user[i] == ans[j])
                    {
                        if (i == j)
                        {
                            a++;
                        }
                        else
                        {
                            b++;
                        }
                    }
                }
            }
            return $"{a}A{b}B";
        }
        public Boolean IsGameover(String userNumber)
        {
            if (GetResult(userNumber) == "3A0B")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
