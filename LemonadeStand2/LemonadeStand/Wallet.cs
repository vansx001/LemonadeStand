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


        public Wallet()
        {
            this.money = 25;
        }
        public void GetMoney()
        {
            Console.WriteLine("Total money in wallet: ${0}",money);
        }
    }
}
