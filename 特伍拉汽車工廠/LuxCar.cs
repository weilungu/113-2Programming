using System;

namespace 特伍拉汽車工廠
{
    internal class LuxCar : Car
    {
        // Attritube
        Engine eng;
        Aircond ac;
        Sound sd;

        // Constractor
        public LuxCar(int cc, string type) : base(cc, type)
        {
            this.eng = new Engine(cc);
            this.ac = new Aircond(type);
            this.sd = new Sound();
        }

        // Method
        public override double GetCost()
        {
            return eng.GetCost() + ac.GetCost() + 10000;
        }

        public override double GetPrice()
        {
            int price = (int)Math.Round(GetCost() * 1.2);
            return price;
        }

    }
}
