using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Super Fly","White",29,"Male");
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */
            myHero.ChargePower(55);
            myHero.Investigate();
            myHero.FightCrime("Zolof");
            myHero.Fly();
            myHero.Climb(2);

            myOtherHero.ChargePower(1);
            myOtherHero.Investigate();
            myOtherHero.FightCrime("Tryst");
            myOtherHero.Fly();
            myOtherHero.Climb(1);

            thirdHero.ChargePower(15);
            thirdHero.Investigate();
            thirdHero.FightCrime("Crux");
            thirdHero.Fly();
            thirdHero.Climb(3);

        }
    }
}