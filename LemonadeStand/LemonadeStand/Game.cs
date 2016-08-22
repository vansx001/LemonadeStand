using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Intro intro = new Intro();
        Player player = new Player("");
        Inventory supply = new Inventory();
        Day day = new Day();
        Store store = new Store();
        Stand stand = new Stand();
        Pitcher pitcher = new Pitcher();
        Recipe recipe = new Recipe();

        public Game()
        {
            
        }
        
        public void RunGame()
        {
            intro.RunIntro();
            player.SetPlayerName();
            player.RunRules();
            while (day.dayOfWeek <= 7)
            {
                day.RunDay(stand, player, store, supply, recipe);
                day.dayOfWeek++;
            }
            DeterminePlayerStatus(player);

        }

        public void DeterminePlayerStatus(Player player)
        {
            Console.Clear();
            Console.WriteLine("Congrats {0}!!! You finished 7 Days of Lemonade Stand!", player.name);
            Console.ReadLine();

        }
        

        
    }
}
