using System;

namespace 特伍拉汽車工廠
{
    internal class Aircond
    {
        // Attribute
        int cost;
        string type;

        // Constractor
        public Aircond(string type)
        {
            this.type = type;
        }

        public int GetCost()
        {
            if (type == "auto")
            {
                cost = 12000;
            }
            else // "manual"
            {
                cost = 10000;
            }

            return cost;
        }
    }
}
