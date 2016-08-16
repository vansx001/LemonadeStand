using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Shop
    {
        public void GetWalletAndInventory()
        {
            Wallet wallet = new Wallet();
            Console.WriteLine("\n\n*** AVAILABLE FUNDS ***");
            Console.WriteLine("You have:\t${0}.\n", wallet.GetWallet());

            Console.WriteLine("\n\n*** CURRENT INVENTORY ***");
            Lemon lemon = new Lemon();
            Console.WriteLine("You have:\t{0} Lemons", lemon.GetQuantityOfLemon());
            Sugar sugar = new Sugar();
            Console.WriteLine("You have:\t{0} Cups of Sugar", sugar.GetQuantityOfSugar());
            Ice ice = new Ice();
            Console.WriteLine("You have:\t{0} Ice Cubes", ice.GetQuantityOfIce());
            Cups cups = new Cups();
            Console.WriteLine("You have:\t{0} Paper Cups", cups.GetQuantityOfCups());

        }
    }
}
