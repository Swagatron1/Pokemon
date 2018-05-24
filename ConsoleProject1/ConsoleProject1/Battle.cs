using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Battle
    {//Battle Fields
        public int health;
        public int damage;
        public int attackdamage;

        public Battle(int health, int damage, int attackdamage)
        {
            this.health = health;
            this.damage = damage;
            this.attackdamage = attackdamage;
        }


    }
}
