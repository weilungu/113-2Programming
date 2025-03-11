using System;

namespace S1131375Ex0310EmployLab
{
    internal class Worker : Employee
    {
        int monthpayment, jobPayment;
        public Worker(string name, int mp, int jp)
        {
            this.name = name;
            this.monthpayment = mp; // 基本月薪
            this.jobPayment = jp; // 工作津貼
        }

        public override int GetPayment() // override: 因為父類別有虛擬方法，使得可以直接改變回傳值
        { // 月薪 = 基本月薪 + 工作津貼；
            int payment = this.monthpayment + this.jobPayment;

            return payment;
        }
        public override int GetBonus()
        {
            int bonus = (int)(1.05 * GetPayment()); // 說明是說 1.1 倍

            return bonus;
        }
    }
}
