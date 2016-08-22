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
                day.RunDay(stand, player, store, supply);
                day.dayOfWeek++;
            }
        }

        //determine if player wins or loses
        public void DeterminePlayerStatus()
        { 
        }
        

        
    }
}
