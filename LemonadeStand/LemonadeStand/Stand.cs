using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Stand
    {
        double answer;
        double newBalance;

        public Stand()
        {
            answer = 0;
            newBalance = 0;
        }

        public double SetCupPrice()
        {
            Console.WriteLine("\nHow much do you want to charge per cup?");
            answer = Convert.ToDouble(Console.ReadLine());
            return answer;
        }
        public double GetNewBalance(Customer customer, Weather weather, Player player)//get new daily balance
        {
            newBalance *= customer.GetCustomersToBuy(weather).Count; 
            player.wallet.money += newBalance;
            return player.wallet.money;
            }
    }
}
