using System;
using System.Globalization;

namespace 特伍拉汽車工廠
{
    internal class BasicCar
    {
        // Attritube
        Engine eng;
        Aircond ac;
        Sound sd;

        // Constractor
        public BasicCar(int cc, string type)
        {
            this.eng = new Engine(cc);
            this.ac = new Aircond(type);
            this.sd = new Sound();
        }

        // Method
        
        public virtual int GetCost()
        {
            return eng.GetCost() + ac.GetCost() + 5000; // 引擎成本 ＋ 空調成本 + 5000
        }

        public virtual int GetPrice()
        {
            int price = (int)Math.Round(GetCost() * 1.2);

            return price;
        }
    }
}
