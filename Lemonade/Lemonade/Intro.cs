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
            Console.WriteLine("You are in need of money! Your parents are kicking you out in 2 weeks and you’ve never had a job before. \nYou will do anything – even open up a Lemonade Stand. Are you up for the challenge?\n\nEnter 'y' for Yes\nEnter 'n' for No");
            answer = Console.ReadLine();

            if (answer == "y")
                {
                Console.Clear();
                Console.WriteLine("Challenge accepted!!");
                Console.WriteLine(".\n.\n.\n.\n.\n.\npress any key to continue");
                Console.ReadLine();
                    
                }
                else if (answer == "n")
                {
                    Console.Clear();
                    Console.WriteLine("See ya!");
                    Console.ReadLine();
                    Environment.Exit(1);
            }
                else
                {
                    Console.WriteLine("\nInvalid option.");
                    Console.ReadLine();
                    Console.Clear();
                    RunIntro();
            }
        }
    }
}
