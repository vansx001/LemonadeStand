using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Intro
    {
        string answer;

        public void RunIntro()
        {
            Console.WriteLine("Welcome to LEMONADE STAND!");
            Console.WriteLine("\n\nYou are in need of money! Your parents are kicking you out in 2 weeks and you’ve never had a job before. \nYou will do anything – even open up a Lemonade Stand. Are you up for the challenge?\n\nEnter 'y' for Yes\nEnter 'n' for No");
            answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.Clear();
                Console.WriteLine("Challenge accepted!!\n press <enter> to continue.");
                Console.ReadLine();

            }
            else if (answer == "n")
            {
                Console.Clear();
                Console.WriteLine("Challenged declined! See ya!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("\nInvalid option.");
                Console.ReadLine();
                Console.Clear();
                RunIntro();
                Console.ReadLine();

            }
        }
    }
}
