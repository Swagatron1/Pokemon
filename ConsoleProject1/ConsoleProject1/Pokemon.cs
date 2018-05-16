using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Pokemon
    {

        //pokemon fields
        public string name;
        public int health = 100;
        public Attack attack1;
        public Attack attack2;
        public Attack attack3;
        public Attack attack4;

        //pokemon contructor
        public Pokemon(string name, int health, Attack attack1, Attack attack2, Attack attack3, Attack attack4)
        {
            this.name = name;
            this.health = health;
            this.attack1 = attack1;
            this.attack2 = attack2;
            this.attack3 = attack3;
            this.attack4 = attack4;
        }
        










    }
}
