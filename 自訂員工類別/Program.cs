using System;

namespace 自訂員工類別
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeType1 james = new EmployeeType1("James Chen", "123456789", 300000, 0.08);
            EmployeeType1 kevin = new EmployeeType1("Kevin Wang", "987654321", 250000, 0.07);

            EmployeeType2 david = new EmployeeType2("David Chiang", "112233445", 150000, 0.03, 12000);
            EmployeeType2 amigo = new EmployeeType2("Amigo Chang", "555556666", 200000, 0.035, 10000);

            // 針對上述 4 位人員：需依序列印出每個人的身分證號、姓名、月薪總額以下指令可以印出 james 的資訊

            Console.WriteLine("id:{0},name:{1},salary:{2}", james.GetId(), james.GetName(), (int)james.GetTotalSalary());
            Console.WriteLine("id:{0},name:{1},salary:{2}", kevin.GetId(), kevin.GetName(), (int)kevin.GetTotalSalary());

            Console.WriteLine("id:{0},name:{1},salary:{2}", david.GetId(), david.GetName(), (int)david.GetTotalSalary());
            Console.WriteLine("id:{0},name:{1},salary:{2}", amigo.GetId(), amigo.GetName(), (int)amigo.GetTotalSalary());


            // 請務必自行增加… 列印其他物件的指令！
            // TODO：補齊的指令, 除了 james, 還需要印出其他三位人員的薪資資訊

        }
    }
}
