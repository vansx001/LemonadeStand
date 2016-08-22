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
            Console.WriteLine("\n*** RECIPE (required ingredients per pitcher) ***");
            Console.WriteLine("Lemon: <4> \t\tSugar: <6> \nIce: <10> \t\tCups: <8>");
        }
    }
}
