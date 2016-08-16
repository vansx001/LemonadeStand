using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Player
    {
        public Player humanPlayerOne;
        public Player computer;
        public string name;
        public string choice;
        public string players;

        public void SetChoice(string choice)
        {
            this.choice = choice;
        }

        public string GetChoice()
        {
            return this.choice;
        }

        public virtual void PickPlayers()
        {
            Console.Clear();
            Console.WriteLine("Please make your selection:\n1 - One Player\n2 - Play Against Computer");
            choice = Console.ReadLine();

            Console.Clear();
            if (choice == "1")
            {
                Console.WriteLine("You chose One Player mode. What is your name?");
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("{0}, let's check your inventory and wallet.", name);
            }
            else if (choice == "2")
            {
                Console.WriteLine("You chose to play against computer. What is your name?");
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("{0}, let's check your inventory and wallet.", name);
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Console.ReadLine();
                PickPlayers();
            }
        }
    }
}
