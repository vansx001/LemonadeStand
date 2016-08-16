using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Sugar
    {
        double costOfSugar;
        double dissolveRateOfSugar;
        int quantityOfSugar;

        public Sugar()
        {
            this.costOfSugar = 0.55;
            this.dissolveRateOfSugar = 0;
            this.quantityOfSugar = 0;
        }

        public void SetCostOfSugar(double NewCostOfSugar)
        {
            this.costOfSugar = NewCostOfSugar;
        }
        public void SetDissolveRateOfSugar()
        {

        }
        public void SetQuantityOfSugar(int PurchasedQuantityOfSugar)
        {
            this.quantityOfSugar = this.quantityOfSugar + PurchasedQuantityOfSugar;
        }
        public double GetCostOfSugar()
        {
            return this.costOfSugar;
        }
        public double GetDissolveRateOfSugar()
        {
            return this.dissolveRateOfSugar;
        }
        public int GetQuantityOfSugar()
        {
            return this.quantityOfSugar;
        }
    }
}
