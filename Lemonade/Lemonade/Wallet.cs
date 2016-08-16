using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Wallet
    {
        private double startingFunds;

        public Wallet()
        {
            this.startingFunds = 25;
        }
        public double GetWallet()
        {
            return this.startingFunds;
        }
    }
}
