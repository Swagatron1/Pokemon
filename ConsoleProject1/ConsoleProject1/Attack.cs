using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Attack
    {
        public string name;
        public int damage;
        public int pp;
        public string type;


        public Attack(string name, int damage, int pp, string type)
        {
            this.name = name;
            this.damage = damage;
            this.pp = pp;
            this.type = type;
        }

        
       
    }
}
