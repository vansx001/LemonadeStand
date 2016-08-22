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


        public Day()
        {
            dayOfWeek = 1;
        }

public void RunDay(Stand stand, Player player, Store store, Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("DAY {0} OF 7.\n press <enter> to continue...", dayOfWeek);
            Console.ReadLine();
            weather.GetWeatherForecast();
            player.wallet.GetMoney();
            recipe.ShowRecipe();
            store.DisplayCostOfSuppliesInStore(inventory);
            store.BuySupplies(player, inventory, store);
            store.GetPitcher();
            stand.SetCupPrice(0);
            customer.GetCustomersToBuy(weather);

            Console.WriteLine("SUMMARY:\n Your new life savings balance: ${0}",player.wallet.GetNewBalance(customer, weather));
            Console.WriteLine();
        }
    }
}
