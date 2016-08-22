using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        double chargePerCup;


        public Stand()
        {
            chargePerCup = 0;

        }

        public double GetCupPrice()
        {
            Console.WriteLine("How much do you want to charge per cup?");
            chargePerCup = Convert.ToDouble(Console.ReadLine());
            return chargePerCup;
        }

        public void SetCupPrice(double chargePerCup)
        {
            this.chargePerCup = chargePerCup;
        }
    }
}
