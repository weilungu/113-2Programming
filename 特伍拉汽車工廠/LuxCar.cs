using System;

namespace 特伍拉汽車工廠
{
    internal class LuxCar : BasicCar
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
        public override int GetCost()
        {
            return eng.GetCost() + ac.GetCost() + 10000;
        }

        public override int GetPrice()
        {
            return base.GetPrice();
        }

    }
}
