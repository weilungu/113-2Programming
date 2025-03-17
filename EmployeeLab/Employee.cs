using System;

namespace S1131375Ex0310EmployLab
{

    // 屬性

    // 建構子？

    // 方法
    //public String GetName()
    //{
    //    // 回傳姓名
    //}

    internal abstract class Employee
    {
        protected string name;

        public string GetName()
        {
            return this.name;
        }

        public abstract int GetPayment(); // virtual: 虛擬方法，可以讓我在子類別改變方法的回傳值
        //{/*空的方法，不用寫指令! 也可以改為抽象方法 */
        //    return 0;
        //}
        public abstract int GetBonus();
        //{/*空的方法，不用寫指令! 也可以改為抽象方法 */
        //    return 0;
        //}
    }
}
