using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Ice
    {
            double costOfIce;
            double meltRateOfIce;
            int quantityOfIce;

            public Ice()
            {
                this.costOfIce = 0.50;
                this.meltRateOfIce = 0;
                this.quantityOfIce = 0;
            }

            public void SetCostOfIce(int NewCostOfIce)
            {
                this.costOfIce = NewCostOfIce;
            }
            public void SetIceMeltRate()
            {

            }
            public void SetQuantityOfIce(int PurchasedQuantityOfIce)
            {
                this.quantityOfIce = this.quantityOfIce + PurchasedQuantityOfIce;
            }
            public double GetCostOfIce()
            {
                return this.costOfIce;
            }
            public double GetMeltRateOfIce()
            {
                return this.meltRateOfIce;
            }
        public int GetQuantityOfIce()
        {
            return this.quantityOfIce;
        }
    }
}
