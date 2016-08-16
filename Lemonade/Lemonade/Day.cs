using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Day
    { 
        public int dayOne;

        public Day()
        {
            dayOne = 1;
        }

        public int GetDate()
        {
            return this.dayOne;
        }
        public void AddDays()
        {
        this.dayOne += 1;
        }

    public void DisplayDate()
        {
            Console.WriteLine("DAY {0}.",dayOne);
            this.dayOne = 1;
        }
    }
}
