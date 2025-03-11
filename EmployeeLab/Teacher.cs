using System;

namespace S1131375Ex0310EmployLab
{
    internal class Teacher : Employee
    {
        int basicPayment, studyPayment,
            otPayMent, overtime;

        public Teacher(string name, int bp, int sp, int op, int ot)
        {
            base.name = name;
            this.basicPayment = bp; // 基本月薪
            this.studyPayment = sp; // 研究費
            this.otPayMent = op; // 超鐘點費
            this.overtime = ot; // 超鐘點時數
        }

        public override int GetPayment() // override: 因為父類別有虛擬方法，使得可以直接改變回傳值
        { // 月薪 = 基本月薪 + 研究費 + 超鐘點費*超鐘點時數；
            int payment = basicPayment + studyPayment + (otPayMent * overtime);

            return payment;
        }
        public override int GetBonus()
        {
            int bonus = (int)(1.2 * (basicPayment + studyPayment)); // 說明是說 1.2倍

            return bonus;
        }
    }
}
