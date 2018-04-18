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
        public int health=100;
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
            return (health - 15);
        }

        public int Scratch()
        {
            return (health - 15);
        }

        public int Earthquake()
         {
            return health - 25;
         }

        public int firespin()
         {
            return health - 35;
         }

        public int Bodyslam()
            {
            return health-25;
            }













    }
}
