using System;

namespace Test_Console
{
    internal class Creature
    {
        int hp;


        public Creature()
        {
            hp = 100;
        }

        public int HP
        {
            get => hp;
            set
            {
                if (value < 0)
                    hp = 0;
                else hp = value;
            }
        }


        //public void Injured(int attacked)
        //{
            
        //}
    }
}
