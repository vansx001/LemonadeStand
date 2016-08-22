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

        public int dayOfWeek;
        string answer;

        public Day()
        {
            dayOfWeek = 1;
        }

public void RunDay(Stand stand, Player player, Store store, Inventory inventory)
        {
            Console.WriteLine("DAY {0} OF 7.\n press <enter> to continue...", dayOfWeek);
            Console.ReadLine();
            weather.GetWeatherForecast();
            player.wallet.GetMoney();
            player.recipe.ShowRecipe();
            store.DisplayCostOfSuppliesInStore(inventory);
            stand.SetCupPrice();

            while (answer != "y" || answer != "n")
            {
                if (player.wallet.money > 0)
                {
                    Console.WriteLine("Do you want to buy supplies? \nEnter 'y' for Yes\nEnter 'n' for No.\n");
                    answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y")
                    {
                        store.BuySupplies(player, inventory);
                    }
                    else if (answer == "n" || answer == "N")
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
            
            Console.WriteLine("SUMMARY:\n Your new life savings balance: ${0}",stand.GetNewBalance(customer, weather, player));
            Console.WriteLine();
        }
    }
}
