using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public Human()
        {

        }

        public void SetUpHuman()
        {
            //Console.Clear();
            //if (choice == "1")
            //{
            //    Console.WriteLine("You chose One Player mode. What is your name?");
            //    name = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine("{0}, let's check your inventory and wallet.",name);
            //}
            //else
            //{
            //    Console.WriteLine("You chose to play against computer. What is your name?");
            //    name = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine("{0}, let's check your inventory and wallet.",name);
            //}
        }
        
    }
}
