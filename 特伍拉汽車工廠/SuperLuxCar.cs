using System;

namespace 特伍拉汽車工廠
{
    internal class SuperLuxCar : LuxCar
    {
        // Attribute
        Engine eng;
        Aircond ac;
        Sound sd;

        // Constractor
        public SuperLuxCar(int cc, string type) : base(cc, type)
        {
            this.eng = new Engine(cc);
            this.ac = new Aircond(type);
            this.sd = new Sound();
        }

        // Method
        public override int GetCost()
        {
            return base.GetCost() + sd.GetCost();
        }
        public override int GetPrice()
        {
            return base.GetPrice();
        }

        public bool IsExpensive(LuxCar lc)
        {
            return GetPrice() > lc.GetPrice();
        }
    }
}
