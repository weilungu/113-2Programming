using System;

namespace 特伍拉汽車工廠
{
    internal abstract class Car
    {
        int cc;
        string type;
        public Car(int cc, string type)
        {
            this.cc = cc;
            this.type = type;
        }

        public abstract double GetCost();
        public abstract double GetPrice();
    }
}
