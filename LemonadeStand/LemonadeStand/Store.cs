using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public List<Pitcher> pitcherList = new List<Pitcher>();
        public List<Lemon> lemonList = new List<Lemon>();
        public List<Ice> iceList = new List<Ice>();
        public List<Sugar> sugarList = new List<Sugar>();
        public List<Cups> cupsList = new List<Cups>();
        public Lemon lemon = new Lemon(0);
        public Ice ice = new Ice(0);
        public Sugar sugar = new Sugar(0);
        public Cups cups = new Cups(0);
        string lemonCount;
        string iceCount;
        string sugarCount;
        string cupsCount;
        public int numberOfPitcher;


        public Store()
        {
        }

        public void DisplayCostOfSuppliesInStore(Inventory inventory)
        {
            Console.WriteLine("\n\nSTORE (COST PER ITEM)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Lemon: ${0} \tSugar: ${1} \tIce ${2} \tCups ${3}",
                lemon.cost,
                sugar.cost,
                ice.cost,
                cups.cost);
        }

        public void BuySupplies(Player player, Inventory inventory, Store store)
        {
            if (player.wallet.money > 0)
            {
                BuyLemon(player, inventory);
                BuySugar(player, inventory);
                BuyIce(player, inventory);
                BuyCups(player, inventory);
            }
            else if (player.wallet.money <= 0)
            { 
                Console.WriteLine("You do not have enough money. Game Over LOSER!");
                Console.ReadLine();
                Environment.Exit(1);
            }

        }
        public List<Pitcher> GetPitcher()
        {
            Console.WriteLine("How many pitchers do you want to make?");
            numberOfPitcher = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPitcher; i++)
            {
                Pitcher pitcher = new Pitcher();
                if (lemonList.Count >= 4 && sugarList.Count >= 6 && iceList.Count >= 10 && cupsList.Count >= 8)
                {
                    pitcherList.Add(pitcher);
                }
                else if (lemonList.Count < 4 && sugarList.Count < 6 && iceList.Count < 10 && cupsList.Count < 8)
                {
                    Console.WriteLine("You do not have enough ingredients to make more pitchers.");
                    Console.ReadLine();
                    break;
                }
            }
            return pitcherList;
        }

        public List<Lemon> BuyLemon(Player player, Inventory inventory)
        {
            if (player.wallet.money > 0)
            {
                Console.WriteLine("How many lemons do you want to buy?");
                lemonCount = Console.ReadLine();
                double lemons = double.Parse(lemonCount);
                double costOfLemons = lemons * lemon.cost;
                player.wallet.money -= costOfLemons;
                player.wallet.GetMoney();
                for (int i = 0; i <= lemons; i++)
                {
                    lemonList.Add(lemon);
                }
            }
            return lemonList;
        }

        public List<Sugar> BuySugar(Player player, Inventory inventory)
        {
            if (player.wallet.money > 0)
            {
                Console.WriteLine("How much sugar do you want to buy?");
                sugarCount = Console.ReadLine();
                double sugars = double.Parse(sugarCount);
                double costOfSugar = sugars * sugar.cost;
                player.wallet.money -= costOfSugar;
                player.wallet.GetMoney();
                for (int i = 0; i <= sugars; i++)
                {
                    sugarList.Add(sugar);
                }
            }
            return sugarList;
        }

        public List<Ice> BuyIce(Player player, Inventory inventory)
        {
            if (player.wallet.money > 0)
            {
                Console.WriteLine("How much ice do you want to buy?");
                iceCount = Console.ReadLine();
                double iceCubes = double.Parse(iceCount);
                double costOfice = iceCubes * ice.cost;
                player.wallet.money -= costOfice;
                player.wallet.GetMoney();
                for (int i = 0; i <= iceCubes; i++)
                {
                    iceList.Add(ice);
                }
            }
            return iceList;
        }
        public List<Cups> BuyCups(Player player, Inventory inventory)
        {
            if (player.wallet.money > 0)
            {
                Console.WriteLine("How many paper cups do you want to buy?");
                cupsCount = Console.ReadLine();
                double paperCups = double.Parse(cupsCount);
                double costOfCups = paperCups * cups.cost;
                player.wallet.money -= costOfCups;
                player.wallet.GetMoney();
                for (int i = 0; i <= paperCups; i++)
                {
                    cupsList.Add(cups);
                }
            }
            return cupsList;
        }
    }
}
