using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Recipe
    {

        public Recipe()
        {
        }

        public void ShowRecipe()
        {
            Console.WriteLine("\nRECIPE (REQUIRED INGREDIENTS PER PITCHER)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Lemons: 4 \tSugar: 6 \tIce: 10 \tCups: 8");
        }
    }
}
