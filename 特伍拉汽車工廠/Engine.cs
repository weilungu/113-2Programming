using System;

namespace 特伍拉汽車工廠
{
    internal class Engine
    {
        // Attritube
        int cost, cc;

        // Constractor
        public Engine(int cc)
        {
            this.cc = cc;
            this.cost = GetCost();
        }

        // Method
        public int GetCost()
        {
            if (this.cc == 1600)
            {
                return 20000;
            }
            else // 2000
            {
                return 25000;
            }
        }
    }
}
