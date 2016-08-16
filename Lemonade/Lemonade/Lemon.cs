using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Lemon
    {
        double costOfLemon;
        double spoilRateOfLemon;
        int quantityOfLemon;

        public Lemon()
        {
            this.costOfLemon = .50;
            this.spoilRateOfLemon = 0;
            this.quantityOfLemon = 0;   
        }

        public void SetCostOfLemon(double NewCostOfLemon)
        {
            this.costOfLemon = NewCostOfLemon;
        }
        public void SetSpoilRateOfLemon()
        {

        }
        public void SetQuantityOfLemon(int PurchasedQuantityOfLemon)
        {
            this.quantityOfLemon = this.quantityOfLemon + PurchasedQuantityOfLemon;
        }
        public double GetCostOfLemon()
        {
            return this.costOfLemon;
        }
        public double GetSpoilRateOfLemon()
        {
            return this.spoilRateOfLemon;
        }
        public int GetQuantityOfLemon()
        {
            return this.quantityOfLemon;
        }
    }
}
