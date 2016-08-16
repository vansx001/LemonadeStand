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

            Player player = new Player();
            player.PickPlayers();

            Human human = new Human();
            human.SetUpHuman();

            Shop shop = new Shop();
            shop.GetWalletAndInventory();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
