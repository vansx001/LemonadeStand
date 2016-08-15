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
            if (choice == "1")
                this.humanPlayerOne = new Human(Console.ReadLine());
        }
        
    }
}
