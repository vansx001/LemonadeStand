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
        public Player humanPlayerTwo;
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
            Console.WriteLine("Make your selection:\n1 - One Player Game\n2 - Two Player Game\n3 - Play Against Computer");
            choice = Console.ReadLine();         
        }
    }
}
