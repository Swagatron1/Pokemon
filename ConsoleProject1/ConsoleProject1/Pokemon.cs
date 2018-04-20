using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Pokemon
    {
        public string name;
        public int health = 100;
        public int attack1;
        public int attack2;
        public int attack3;
        public int attack4;


        public Pokemon(string name, int health, int attack1, int attack2, int attack3, int attack4)
        {
            this.name = name;
            this.health = health;
            this.attack1 = attack1;
            this.attack2 = attack2;
            this.attack3 = attack3;
            this.attack4 = attack4;
        }

        public int Ember()
        {
            return (Enemyhealth - 15);
        }

        public int Scratch()
        {
            return (Enemyhealth - 15);
        }

        public int Earthquake()
        {
            return Enemyhealth - 25;
        }

        public int firespin()
        {
            return Enemyhealth - 35;
        }

        public int Bodyslam()
        {
            return Enemyhealth - 20;
        }

        public int thunder()
        {
            return Enemyhealth - 30;
        }
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
