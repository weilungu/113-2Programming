using System;

namespace 特伍拉汽車工廠
{
    internal class Engin
    {
        // Attritube
        int cost, cc;

        // Constractor
        public Engin(int cc)
        {
            this.cc = cc;
            this.cost = getCost();
        }

        // Method
        public int getCost()
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
