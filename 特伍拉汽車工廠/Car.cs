using System;

namespace 特伍拉汽車工廠
{
    internal abstract class Car
    {
        int cc;
        string type;
        protected Car(int cc, string type)
        {
           this.cc = cc;
           this.type = type;
        }
        public abstract int GetCost();
        public abstract int GetPrice();
        
        public int CC { get => cc;}
        public string TYPE { get => type;}
    }
}
