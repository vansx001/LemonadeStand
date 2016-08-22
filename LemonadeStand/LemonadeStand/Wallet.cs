using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money;
        public double newBalance;
        public double totalSales;

        public Wallet()
        {
            this.money = 25;
            newBalance = 0;
        }
        public void GetMoney()
        {
            Console.WriteLine("Total money in wallet: ${0}",this.money);
        }
        public double GetNewBalance(Customer customer, Weather weather, Stand stand)
            
        {
            newBalance = customer.GetCustomersToBuy(weather).Count * stand.GetCupPrice();
            this.money = newBalance;
            return this.money;
        }
    }
}
