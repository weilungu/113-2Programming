using System;

namespace 特伍拉汽車工廠
{
    internal class BasicCar
    {
        // Attritube
        Engin eng;
        AirCond ac;

        // Constractor
        public BasicCar(int cc, string type)
        {
            this.eng = new Engin(cc);
            this.ac = new AirCond(type);
        }

        // Method
        public int getPrice()
        {
            int price = (int)Math.Round(getCost() * 1.2);

            return price;
        }
        public int getCost()
        {
            return eng.getCost() + ac.getCost() + 5000; // 引擎成本 ＋ 空調成本 + 5000
        }
    }
}
