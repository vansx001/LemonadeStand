using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet wallet = new Wallet();
        
        public string name;

        public Player(string name)
        {
            this.name = name;
        }
        
        public void SetPlayerName()
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public void RunRules()
        {
            Console.Clear();
            Console.WriteLine("{0}, the rules are simple:", name);
            Console.WriteLine("- You have $25 in your life savings to buy supplies for your lemonade stand.");
            Console.WriteLine("- In 7 days try to make as much money as possible.");
            Console.WriteLine("- Keep in mind that weather conditions affect your possible sales for the day.");
            Console.WriteLine("- Since you're the boss you get to determine the price per cup.");
            Console.WriteLine("\n\t press <enter> to continue...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
