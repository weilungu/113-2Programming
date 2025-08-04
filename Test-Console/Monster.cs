using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console
{
    internal class Monster : Creature
    {
        int hurt;
        public Monster()
        {
            hurt = 10;
        }

        public virtual void Attack(Creature c)
        {
            c.HP -= hurt;
            
            
        }
    }
}
