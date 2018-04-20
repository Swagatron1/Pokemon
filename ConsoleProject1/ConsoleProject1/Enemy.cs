using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Enemy
    {
        public string enemyname;
        public int enemyhealth = 100;
        public int enemyattack1;
        public int enemyattack2;
        public int enemyattack3;
        public int enemyattack4;

        public Enemy(string enemyname, int enemyhealth, int enemyattack1, int enemyattack2, int enemyattack3)
        {
            this.enemyname = enemyname;
            this.enemyhealth = enemyhealth;
            this.enemyattack1 = enemyattack1;
            this.enemyattack2 = enemyattack2;
            this.enemyattack3 = enemyattack3;
        }

    }

}
