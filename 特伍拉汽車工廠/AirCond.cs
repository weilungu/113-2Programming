using System;

namespace 特伍拉汽車工廠
{
    internal class AirCond
    {
        // Attribute
        int cost;
        string type;

        // Constractor
        public AirCond(string type)
        {
            this.type = type;
        }

        public int getCost()
        {
            if (this.type == "auto")
            {
                this.cost = 12000;
            }
            else // "manual"
            {
                this.cost = 10000;
            }

            return this.cost;
        }
    }
}
