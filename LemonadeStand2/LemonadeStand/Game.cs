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
        Player player = new Player("name");
        Inventory supply = new Inventory();
        Day day = new Day();
        Store store = new Store();
        Stand stand = new Stand();
        int week = 8;

        public Game()
        {
            
        }
        
        public void RunGame()
        {
            intro.RunIntro();
            player.SetPlayerName();
            player.RunRules();

            for (int i = 0; i < week; i++)
            {
                if (player.wallet.money > 0)
                {
                    Console.WriteLine("Day {0} of 7.\n Press <enter> to continue", i + 1);
                    Console.ReadLine();
                    day.RunStartOfDay(stand, player, store, supply);
                }
                else
                {
                    Console.WriteLine("You do not have enough to play. GAME OVER!");
                    break;
                }
            }
            
        }

        //determine if player wins or loses
        public void DeterminePlayerStatus()
        { 
        }
        

        
    }
}
