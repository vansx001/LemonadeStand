using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather = new Weather();
        Random random = new Random();
        Customer customer = new Customer();

        public decimal cupPrice;
        public int dayNumber = 0;
        public decimal dailyDollarsEarned;
        public int numberGlassesBought = 0;
        string answer;

        public Day()
        {
           dayNumber++;
        }

        public void RunStartOfDay(Stand stand, Player player, Store store, Inventory inventory)
        {
            string answer = "";
            weather.GetWeatherForecast();
            player.wallet.GetMoney();
            player.recipe.ShowRecipe();
            store.DisplayCostOfSuppliesInStore(inventory);

                    
            while (answer != "y" || answer !="n")
            {
                if (player.wallet.money > 0)
                {
                    Console.WriteLine("Do you want to buy supplies? \nEnter 'y' for Yes\nEnter 'n' for No.\n");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        store.BuySupplies(player, inventory);
                    }
                    else if (answer == "n")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid option.");
                        Console.ReadLine();
                    }
                }
                else break;
        }
            customer.GetCustomersToBuy(weather);

        }

        public void MakeCustomers()
        {
            
        }
        
        
    }

}
