using EmployeeLab;
using System;

namespace S1131375Ex0310EmployLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 物件陣列: 儲存測試物件(2位老師)。
            //Employee[] members = new Employee[2];
            //members[0] = new Teacher("James Chen", 32000, 30000, 525, 3);
            //members[1] = new Teacher("Kevin Wang", 35000, 30000, 600, 2);
            //// 利用迴圈逐一取得人員，計算並列印出每位員工的姓名、月薪和年終獎金
            //for (int i = 0; i < members.Length; i++)
            //{
            //    Employee p = members[i]; // 逐一取出所有物件 (可能是教師或是職員)。
            //    Console.WriteLine("Name:{0},Salary:{1:d},Bonus:{2:d}",
            //                      p.GetName(), p.GetPayment(), p.GetBonus());
            //}




            string[] input = Console.ReadLine().Split();
            int tNums = int.Parse(input[0]);
            int wNums = int.Parse(input[1]);

            string[] allDatas = new string[tNums + wNums];
            for (int i = 0; i < allDatas.Length; i++)
            {
                allDatas[i] = Console.ReadLine();
            }

            Employee[] members = new Employee[tNums + wNums];
            for (int i = 0; i < tNums; i++)
            {
                string[] teachersData = allDatas[i].Split(',');

                string name;
                int bp, sp, op, ot;

                name = teachersData[0];
                bp = int.Parse(teachersData[1]);
                sp = int.Parse(teachersData[2]);
                op = int.Parse(teachersData[3]);
                ot = int.Parse(teachersData[4]);

                members[i] = new Teacher(name, bp, sp, op, ot);
            } // 連續讀取teacher的資料
            for (int j = tNums; j < tNums + wNums; j++)
            {
                string[] workersData = allDatas[j].Split(',');

                string name;
                int mp, jp;

                name = workersData[0];
                mp = int.Parse(workersData[1]);
                jp = int.Parse(workersData[2]);

                members[j] = new Worker(name, mp, jp);
            } // 連續讀取worker的資料

            // 利用迴圈逐一取得人員，計算並列印出每位員工的姓名、月薪和年終獎金

            for (int i = 0; i < members.Length; i++)
            {
                Employee p = members[i]; // 逐一取出所有物件 (可能是教師或是職員)。
                Console.WriteLine("Name:{0},Salary:{1},Bonus:{2}",
                p.GetName(), p.GetPayment(), p.GetBonus());
            }

            // 123123123


            // 物件陣列: 儲存各類別的測試物件(4 個人)。
            //Employee[] members = { 
            //    new Teacher("James Chen", 32000, 30000, 525, 3),
            //    new Worker("Peter Lee", 30000, 8000),
            //    new Teacher("Kevin Wang", 35000, 30000, 600, 2),
            //    new Worker("John Chang", 25000, 5000)
            //};

            // 利用迴圈逐一取得人員，計算並列印出每位員工的姓名、月薪和年終獎金

            //for (int i = 0; i < members.Length; i++)
            //{
            //    Employee p = members[i]; // 逐一取出所有物件 (可能是教師或是職員)。
            //    Console.WriteLine("Name:{0},Salary:{1},Bonus:{2}",
            //    p.getName(), p.getPayment(), p.getBonus());
            //}
        }
    }
}