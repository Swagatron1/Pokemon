using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    class Attack
    {
        Ember
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
    }
}
