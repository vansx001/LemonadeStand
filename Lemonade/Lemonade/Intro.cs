using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Intro
    {
        string answer;

        public void RunIntro()
        {
            Console.WriteLine("Welcome to LEMONADE STAND. Do you want to play?\nEnter 'y' for Yes\nEnter 'n' for No");
            answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.Clear();
                Console.WriteLine("GREAT!! Before we start the game, here are some goals to keep in mind:\n- In SEVEN days, make as much money as possible.\n- Increase your starting funds of $25. \n- Correctly price your product, control inventory, and purchase supplies.\n\nBuy your ingredients and start selling!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Okay, maybe next time! See ya!");
            }
        }
    }
}
