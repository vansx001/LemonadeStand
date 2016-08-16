using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Cups
    {
        double costOfCups;
        double soldCups;
        int quantityOfCups;

        public Cups()
        {
            this.costOfCups = 1.00;
            this.soldCups = 0;
            this.quantityOfCups = 0;
        }

        public void SetCostOfCups(int NewCostOfCups)
        {
            this.costOfCups = NewCostOfCups;
        }

        public void SetQuantityOfCups(int PurchasedQuantityOfCups)
        {
            this.quantityOfCups = this.quantityOfCups + PurchasedQuantityOfCups;
        }
        public double GetCostOfCups()
        {
            return this.costOfCups;
        }
        public int GetQuantityOfCups()
        {
            return this.quantityOfCups;
        }
    }
}
