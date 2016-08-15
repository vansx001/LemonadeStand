using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game
    {
        public void RunGame()
        {
            Intro intro = new Intro();
            intro.RunIntro();
            Human humanPlayer = new Human();
            humanPlayer.PickPlayers();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
