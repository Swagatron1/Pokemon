// File/Project Prolog
// Name:     <David Herring and Caleb Norton>
// Period:   <PUT YOUR PERIOD HERE>
// Username: herridav000
// Project:  ConsoleProject1
// Date:     4/12/2018 8:42:10 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ConsoleProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            //creating attacks
            Attack ember = new Attack("ember", 15, 15, "fire");
            Attack scratch = new Attack("scratch",10,20, "normal");
            Attack firespin = new Attack("firespin",30,5, "fire");
            Attack tackle = new Attack("tackle",15,20, "normal");
            Attack quick_attack = new Attack("quick attack",15,15, "normal");
            Attack slam = new Attack("slam",20,15, "normal");
            Attack rock_throw = new Attack("rock throw",25,10, "rock");
            Attack water_gun = new Attack("water gun",25,5, "water");
            Attack bubble = new Attack(" bubble",20,10, "water");
            Attack thunder = new Attack("thunder",25,5, "eletric");
            Attack thunder_bolt = new Attack("thunder bolt",30,5, "eletric");
            Attack razor_leaf = new Attack("razor_leaf",25,5, "grass");
            Attack vine_whip = new Attack("vine_whip",15,15, "grass");
            Attack absorb = new Attack("absorb",15,20, "grass");
            Attack petal_dance = new Attack("petal_dance",20,10, "grass");
            Attack acid = new Attack("acid",20,10, "poison");
            Attack mud_shot = new Attack("mud shot",15,10, "ground");
            Attack mud_slap = new Attack("mudslap",15,15, "ground");
            Attack dragon_claw = new Attack("dragon_claw",30, 5, "dragon");
            Attack dragon_tail = new Attack("dragon_tail", 25, 5, "dragon");
            Attack aqua_tail = new Attack("aqua_tail", 20, 10, "water");
            Attack solor_blade = new Attack("solor_blade", 20, 15, "grass");
            Attack solor_beam = new Attack("solor_beam", 25, 5, "grass");

            //Creating pokemon
            Pokemon Charmander=new Pokemon("Charmander",100,ember,scratch,firespin,tackle);
            Pokemon Pikachu = new Pokemon("Pikachu", 100,quick_attack,thunder,thunder_bolt,slam);
            Pokemon Squirtle = new Pokemon("Squirtle", 100,water_gun,bubble,quick_attack,scratch);
            Pokemon Bulbasaur = new Pokemon("Bulbasuar", 100,vine_whip,acid,petal_dance,razor_leaf);
            Pokemon Geodude = new Pokemon("Geodude", 100,tackle,slam,rock_throw,mud_slap);
            Pokemon Piplup = new Pokemon("Piplup",100,water_gun,bubble,scratch,slam);
            Pokemon Turtonator = new Pokemon("Turtonator",100,firespin,ember,tackle,dragon_claw);
            Pokemon Falamedeiros = new Pokemon("Falamedeiros",100,ember, scratch, slam, firespin);
            Pokemon Rowlet = new Pokemon("Rowlet",100,solor_beam, petal_dance,absorb,acid);

            //actual code to choose pokemon
            Console.WriteLine("Choose Your Pokemon!");
            List< Pokemon> selection = new List<Pokemon > { Charmander, Pikachu, Squirtle, Bulbasaur,Geodude,Piplup,Turtonator,Falamedeiros,Rowlet};
           //listing pokemon for player to choose from
            for (int x = 0; x < selection.Count; x++)
            {
                Pokemon p = selection[x];
                Console.WriteLine(p.name);
            }
            Console.WriteLine("Type what pokemon you want");
            //chosing pokemon
           foreach(Pokemon choice in selection)
            {
                


            }







            // Your code goes above here
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
